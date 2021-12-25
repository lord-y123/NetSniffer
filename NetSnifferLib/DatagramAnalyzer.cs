﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSnifferLib.NetworkLayer;

namespace NetSnifferLib
{
    public static class DatagramAnalyzer
    {
        static readonly LinkLayer.EthernetAnalyzer _ethernetAnalyzer;

        static readonly NetworkLayer.IpV4Analyzer _ipV4Analyzer;
        static readonly NetworkLayer.IpV6Analyzer _ipV6Analyzer;

        static readonly TransportLayer.UdpAnalyzer _udpAnalyzer;
        static readonly TransportLayer.TcpAnalyzer _tcpAnalyzer;

        static DatagramAnalyzer()
        {
            _ethernetAnalyzer = new LinkLayer.EthernetAnalyzer();

            _ipV4Analyzer = new NetworkLayer.IpV4Analyzer();
            _ipV6Analyzer = new NetworkLayer.IpV6Analyzer();

            _udpAnalyzer = new TransportLayer.UdpAnalyzer();
            _tcpAnalyzer = new TransportLayer.TcpAnalyzer();
        }

        public static LinkLayer.EthernetAnalyzer EthernetAnalyzer => _ethernetAnalyzer;

        public static NetworkLayer.IpV4Analyzer IpV4Analyzer => _ipV4Analyzer;

        public static NetworkLayer.IpV6Analyzer IpV6Analyzer => _ipV6Analyzer;

        public static TransportLayer.UdpAnalyzer UdpAnalyzer => _udpAnalyzer;

        public static TransportLayer.TcpAnalyzer TcpAnalyzer => _tcpAnalyzer;
    }
}
