﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSnifferLib
{
    internal class ProtocolNameComparer : IComparer<string>
    {
        static readonly Dictionary<string, int> layers = new()
        {
            { "eth", 4 },
            { "arp", 5 },
            { "ip", 6 },
            { "ipv6", 6 },
            { "icmp", 7 },
            { "udp", 8 },
            { "tcp", 8 },
            { "dhcp", 14 },
            { "dns", 14 },
            { "http", 14 }
        };

        public static string Simplify(string protocol)
        {
            protocol = protocol.ToLower().Trim();

            return protocol switch
            {
                "ethernet" => "eth",
                "ipv4" => "ip",
                _ => protocol,
            };
        }

        public static bool IsValidProtocol(string protocol)
        {
            var simplified = Simplify(protocol);
            return protocol is not "dns" and not "dhcp" and not "http" && layers.ContainsKey(simplified);
        }

        public int Compare(string x, string y)
        {
            return layers[Simplify(x)] - layers[Simplify(y)];
        }
    }
}