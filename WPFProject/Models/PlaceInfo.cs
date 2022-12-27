﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFProject.Models
{
    internal class PlaceInfo
    {
        public string? CountryName { get; set; }

        public Point Location { get; set; }

        public IEnumerable<ConfirmedCount>? Counts { get; set; }
    }

    internal class CountryInfo : PlaceInfo
    {
        public IEnumerable<ProvinceInfo>? ProvinceCounts {  get; set; }
    }

    internal class ProvinceInfo : PlaceInfo { }
    internal struct ConfirmedCount
    {
        public DateTime Date {  get; set; }
        public int Count { get; set; }
    }

    internal struct DataPoint
    {
        public int XValue { get; set; }
        public int YValue { get; set; } 
    }
}