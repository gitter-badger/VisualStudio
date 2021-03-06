﻿using System.Globalization;
using Octokit;

namespace GitHub.Models
{
    public class LicenseItem
    {
        static readonly LicenseItem none = new LicenseItem();
        public static LicenseItem None { get { return none; } }

        public LicenseItem(string key, string name)
        {
            Key = key;
            Name = name;
            Recommended = IsRecommended(key);
        }

        LicenseItem()
        {
            Key = "";
            Name = "None";
            Recommended = true;
        }

        public static bool IsRecommended(string licenseKey)
        {
            return licenseKey == "mit" || licenseKey == "gpl-2.0" || licenseKey == "apache-2.0";
        }

        public string Key { get; private set; }

        public string Name { get; private set; }

        public bool Recommended { get; private set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "License: {0} Recommended: {1}", Key, Recommended);
            }
        }
    }
}
