using System;

namespace Null.ConsoleEx
{
    public static class ConsoleEx
    {
        public static bool IsWideDisplayChar(char c)
        {
            return GetCharDisplayLength(c) > 1;
        }
        public static int GetCharDisplayLength(char c)
        {
            int index = c;
            if (index > 0 && index < 7)
                return 1;
            else if (index > 7 && index < 9)
                return 0;
            else if (index > 9 && index < 10)
                return 8;
            else if (index > 10 && index < 11)
                return 0;
            else if (index > 11 && index < 13)
                return 1;
            else if (index > 13 && index < 14)
                return 0;
            else if (index > 14 && index < 162)
                return 1;
            else if (index > 162 && index < 166)
                return 2;
            else if (index > 166 && index < 167)
                return 1;
            else if (index > 167 && index < 169)
                return 2;
            else if (index > 169 && index < 175)
                return 1;
            else if (index > 175 && index < 178)
                return 2;
            else if (index > 178 && index < 180)
                return 1;
            else if (index > 180 && index < 182)
                return 2;
            else if (index > 182 && index < 183)
                return 1;
            else if (index > 183 && index < 184)
                return 2;
            else if (index > 184 && index < 215)
                return 1;
            else if (index > 215 && index < 216)
                return 2;
            else if (index > 216 && index < 247)
                return 1;
            else if (index > 247 && index < 248)
                return 2;
            else if (index > 248 && index < 449)
                return 1;
            else if (index > 449 && index < 450)
                return 2;
            else if (index > 450 && index < 711)
                return 1;
            else if (index > 711 && index < 712)
                return 2;
            else if (index > 712 && index < 713)
                return 1;
            else if (index > 713 && index < 716)
                return 2;
            else if (index > 716 && index < 729)
                return 1;
            else if (index > 729 && index < 730)
                return 2;
            else if (index > 730 && index < 913)
                return 1;
            else if (index > 913 && index < 930)
                return 2;
            else if (index > 930 && index < 931)
                return 1;
            else if (index > 931 && index < 938)
                return 2;
            else if (index > 938 && index < 945)
                return 1;
            else if (index > 945 && index < 962)
                return 2;
            else if (index > 962 && index < 963)
                return 1;
            else if (index > 963 && index < 970)
                return 2;
            else if (index > 970 && index < 1025)
                return 1;
            else if (index > 1025 && index < 1026)
                return 2;
            else if (index > 1026 && index < 1040)
                return 1;
            else if (index > 1040 && index < 1104)
                return 2;
            else if (index > 1104 && index < 1105)
                return 1;
            else if (index > 1105 && index < 1106)
                return 2;
            else if (index > 1106 && index < 8208)
                return 1;
            else if (index > 8208 && index < 8209)
                return 2;
            else if (index > 8209 && index < 8211)
                return 1;
            else if (index > 8211 && index < 8215)
                return 2;
            else if (index > 8215 && index < 8216)
                return 1;
            else if (index > 8216 && index < 8218)
                return 2;
            else if (index > 8218 && index < 8220)
                return 1;
            else if (index > 8220 && index < 8222)
                return 2;
            else if (index > 8222 && index < 8229)
                return 1;
            else if (index > 8229 && index < 8231)
                return 2;
            else if (index > 8231 && index < 8240)
                return 1;
            else if (index > 8240 && index < 8241)
                return 2;
            else if (index > 8241 && index < 8242)
                return 1;
            else if (index > 8242 && index < 8244)
                return 2;
            else if (index > 8244 && index < 8245)
                return 1;
            else if (index > 8245 && index < 8246)
                return 2;
            else if (index > 8246 && index < 8251)
                return 1;
            else if (index > 8251 && index < 8252)
                return 2;
            else if (index > 8252 && index < 8254)
                return 1;
            else if (index > 8254 && index < 8255)
                return 2;
            else if (index > 8255 && index < 8364)
                return 1;
            else if (index > 8364 && index < 8365)
                return 2;
            else if (index > 8365 && index < 8451)
                return 1;
            else if (index > 8451 && index < 8452)
                return 2;
            else if (index > 8452 && index < 8453)
                return 1;
            else if (index > 8453 && index < 8454)
                return 2;
            else if (index > 8454 && index < 8457)
                return 1;
            else if (index > 8457 && index < 8458)
                return 2;
            else if (index > 8458 && index < 8470)
                return 1;
            else if (index > 8470 && index < 8471)
                return 2;
            else if (index > 8471 && index < 8481)
                return 1;
            else if (index > 8481 && index < 8482)
                return 2;
            else if (index > 8482 && index < 8544)
                return 1;
            else if (index > 8544 && index < 8556)
                return 2;
            else if (index > 8556 && index < 8560)
                return 1;
            else if (index > 8560 && index < 8570)
                return 2;
            else if (index > 8570 && index < 8592)
                return 1;
            else if (index > 8592 && index < 8596)
                return 2;
            else if (index > 8596 && index < 8598)
                return 1;
            else if (index > 8598 && index < 8602)
                return 2;
            else if (index > 8602 && index < 8712)
                return 1;
            else if (index > 8712 && index < 8713)
                return 2;
            else if (index > 8713 && index < 8719)
                return 1;
            else if (index > 8719 && index < 8720)
                return 2;
            else if (index > 8720 && index < 8721)
                return 1;
            else if (index > 8721 && index < 8722)
                return 2;
            else if (index > 8722 && index < 8725)
                return 1;
            else if (index > 8725 && index < 8726)
                return 2;
            else if (index > 8726 && index < 8728)
                return 1;
            else if (index > 8728 && index < 8729)
                return 2;
            else if (index > 8729 && index < 8730)
                return 1;
            else if (index > 8730 && index < 8731)
                return 2;
            else if (index > 8731 && index < 8733)
                return 1;
            else if (index > 8733 && index < 8737)
                return 2;
            else if (index > 8737 && index < 8739)
                return 1;
            else if (index > 8739 && index < 8740)
                return 2;
            else if (index > 8740 && index < 8741)
                return 1;
            else if (index > 8741 && index < 8742)
                return 2;
            else if (index > 8742 && index < 8743)
                return 1;
            else if (index > 8743 && index < 8748)
                return 2;
            else if (index > 8748 && index < 8750)
                return 1;
            else if (index > 8750 && index < 8751)
                return 2;
            else if (index > 8751 && index < 8756)
                return 1;
            else if (index > 8756 && index < 8760)
                return 2;
            else if (index > 8760 && index < 8764)
                return 1;
            else if (index > 8764 && index < 8766)
                return 2;
            else if (index > 8766 && index < 8776)
                return 1;
            else if (index > 8776 && index < 8777)
                return 2;
            else if (index > 8777 && index < 8780)
                return 1;
            else if (index > 8780 && index < 8781)
                return 2;
            else if (index > 8781 && index < 8786)
                return 1;
            else if (index > 8786 && index < 8787)
                return 2;
            else if (index > 8787 && index < 8800)
                return 1;
            else if (index > 8800 && index < 8802)
                return 2;
            else if (index > 8802 && index < 8804)
                return 1;
            else if (index > 8804 && index < 8808)
                return 2;
            else if (index > 8808 && index < 8814)
                return 1;
            else if (index > 8814 && index < 8816)
                return 2;
            else if (index > 8816 && index < 8853)
                return 1;
            else if (index > 8853 && index < 8854)
                return 2;
            else if (index > 8854 && index < 8857)
                return 1;
            else if (index > 8857 && index < 8858)
                return 2;
            else if (index > 8858 && index < 8869)
                return 1;
            else if (index > 8869 && index < 8870)
                return 2;
            else if (index > 8870 && index < 8895)
                return 1;
            else if (index > 8895 && index < 8896)
                return 2;
            else if (index > 8896 && index < 8978)
                return 1;
            else if (index > 8978 && index < 8979)
                return 2;
            else if (index > 8979 && index < 9312)
                return 1;
            else if (index > 9312 && index < 9322)
                return 2;
            else if (index > 9322 && index < 9332)
                return 1;
            else if (index > 9332 && index < 9372)
                return 2;
            else if (index > 9372 && index < 9632)
                return 1;
            else if (index > 9632 && index < 9634)
                return 2;
            else if (index > 9634 && index < 9650)
                return 1;
            else if (index > 9650 && index < 9652)
                return 2;
            else if (index > 9652 && index < 9660)
                return 1;
            else if (index > 9660 && index < 9662)
                return 2;
            else if (index > 9662 && index < 9670)
                return 1;
            else if (index > 9670 && index < 9672)
                return 2;
            else if (index > 9672 && index < 9675)
                return 1;
            else if (index > 9675 && index < 9676)
                return 2;
            else if (index > 9676 && index < 9678)
                return 1;
            else if (index > 9678 && index < 9680)
                return 2;
            else if (index > 9680 && index < 9698)
                return 1;
            else if (index > 9698 && index < 9702)
                return 2;
            else if (index > 9702 && index < 9733)
                return 1;
            else if (index > 9733 && index < 9735)
                return 2;
            else if (index > 9735 && index < 9737)
                return 1;
            else if (index > 9737 && index < 9738)
                return 2;
            else if (index > 9738 && index < 9792)
                return 1;
            else if (index > 9792 && index < 9793)
                return 2;
            else if (index > 9793 && index < 9794)
                return 1;
            else if (index > 9794 && index < 9795)
                return 2;
            else if (index > 9795 && index < 12288)
                return 1;
            else if (index > 12288 && index < 12292)
                return 2;
            else if (index > 12292 && index < 12293)
                return 1;
            else if (index > 12293 && index < 12312)
                return 2;
            else if (index > 12312 && index < 12317)
                return 1;
            else if (index > 12317 && index < 12319)
                return 2;
            else if (index > 12319 && index < 12321)
                return 1;
            else if (index > 12321 && index < 12330)
                return 2;
            else if (index > 12330 && index < 12353)
                return 1;
            else if (index > 12353 && index < 12436)
                return 2;
            else if (index > 12436 && index < 12443)
                return 1;
            else if (index > 12443 && index < 12447)
                return 2;
            else if (index > 12447 && index < 12449)
                return 1;
            else if (index > 12449 && index < 12535)
                return 2;
            else if (index > 12535 && index < 12540)
                return 1;
            else if (index > 12540 && index < 12543)
                return 2;
            else if (index > 12543 && index < 12549)
                return 1;
            else if (index > 12549 && index < 12586)
                return 2;
            else if (index > 12586 && index < 12690)
                return 1;
            else if (index > 12690 && index < 12704)
                return 2;
            else if (index > 12704 && index < 12832)
                return 1;
            else if (index > 12832 && index < 12868)
                return 2;
            else if (index > 12868 && index < 12928)
                return 1;
            else if (index > 12928 && index < 12958)
                return 2;
            else if (index > 12958 && index < 12959)
                return 1;
            else if (index > 12959 && index < 12964)
                return 2;
            else if (index > 12964 && index < 12969)
                return 1;
            else if (index > 12969 && index < 12977)
                return 2;
            else if (index > 12977 && index < 13198)
                return 1;
            else if (index > 13198 && index < 13200)
                return 2;
            else if (index > 13200 && index < 13212)
                return 1;
            else if (index > 13212 && index < 13215)
                return 2;
            else if (index > 13215 && index < 13217)
                return 1;
            else if (index > 13217 && index < 13218)
                return 2;
            else if (index > 13218 && index < 13252)
                return 1;
            else if (index > 13252 && index < 13253)
                return 2;
            else if (index > 13253 && index < 13262)
                return 1;
            else if (index > 13262 && index < 13263)
                return 2;
            else if (index > 13263 && index < 13265)
                return 1;
            else if (index > 13265 && index < 13267)
                return 2;
            else if (index > 13267 && index < 13269)
                return 1;
            else if (index > 13269 && index < 13270)
                return 2;
            else if (index > 13270 && index < 19968)
                return 1;
            else if (index > 19968 && index < 40870)
                return 2;
            else if (index > 40870 && index < 55296)
                return 1;
            else if (index > 55296 && index < 55297)
                return 0;
            else if (index > 55297 && index < 56320)
                return 1;
            else if (index > 56320 && index < 56321)
                return 2;
            else if (index > 56321 && index < 57344)
                return 1;
            else if (index > 57344 && index < 59335)
                return 2;
            else if (index > 59335 && index < 59337)
                return 1;
            else if (index > 59337 && index < 59493)
                return 2;
            else if (index > 59493 && index < 63733)
                return 1;
            else if (index > 63733 && index < 63734)
                return 2;
            else if (index > 63734 && index < 63744)
                return 1;
            else if (index > 63744 && index < 64046)
                return 2;
            else if (index > 64046 && index < 65072)
                return 1;
            else if (index > 65072 && index < 65074)
                return 2;
            else if (index > 65074 && index < 65075)
                return 1;
            else if (index > 65075 && index < 65093)
                return 2;
            else if (index > 65093 && index < 65097)
                return 1;
            else if (index > 65097 && index < 65107)
                return 2;
            else if (index > 65107 && index < 65108)
                return 1;
            else if (index > 65108 && index < 65112)
                return 2;
            else if (index > 65112 && index < 65113)
                return 1;
            else if (index > 65113 && index < 65127)
                return 2;
            else if (index > 65127 && index < 65128)
                return 1;
            else if (index > 65128 && index < 65132)
                return 2;
            else if (index > 65132 && index < 65281)
                return 1;
            else if (index > 65281 && index < 65375)
                return 2;
            else if (index > 65375 && index < 65504)
                return 1;
            else if (index > 65504 && index < 65510)
                return 2;
            else
                return 0;
        }
        public static int GetStringDisplayLength(string str)
        {
            int total = 0;
            foreach (char c in str)
            {
                int i = c;
                total += GetCharDisplayLength(c);
            }
            return total;
        }
    }
    public static class ConsoleExS
    {
        public static bool IsWideDisplayChar(char c)
        {
            return ConsoleEx.IsWideDisplayChar(c);
        }
        public static int GetCharDisplayLength(char c)
        {
            return ConsoleEx.GetCharDisplayLength(c);
        }
        public static int GetStringDisplayLength(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");

            return ConsoleEx.GetStringDisplayLength(str);
        }
    }
}
