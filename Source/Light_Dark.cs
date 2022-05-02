using System.Drawing;

namespace LoginPage
{
   public static class Light_Dark
    {
        public static Color panelheader;
        public static Color panelbtn;
        public static Color mainform;
        public static Color postcolor;
        public static Color ffontco;
        public static Color actcolor;
        public static Color hovcolor;
        public static string mode;



        //Dark
        private static readonly Color panelheaderD = Color.FromArgb(25, 35, 50);
        private static readonly Color panelbtnD = Color.FromArgb(25, 35, 50);
        private static readonly Color mainformD = Color.FromArgb(32, 47, 66);
        private static readonly Color postcolorD = Color.FromArgb(41, 41, 41);
        private static readonly Color ffontcoD = Color.White;
        private static readonly Color actcolorD = Color.FromArgb(10, 10, 10);
        private static readonly Color hovcolorD = Color.FromArgb(10, 10, 10);
        private static readonly string modeD  = "FluentDark";
        //Light

        private static readonly Color panelheaderL = Color.FromArgb(25, 35, 50);
        private static readonly Color panelbtnL = Color.FromArgb(235, 235, 235);
        private static readonly Color mainformL = Color.FromArgb(245, 245, 245);
        private static readonly Color postcolorL = Color.White;
        private static readonly Color ffontcoL = Color.FromArgb(36,36,36);
        private static readonly Color actcolorL = Color.FromArgb(10, 10, 10);
        private static readonly Color hovcolorL = Color.FromArgb(10, 10, 10);
        private static readonly string modeL = "ControlDefault";


        public static void themeChanger (string teme)
        {

            if(teme == "Dark")
            {
                panelheader = panelheaderD;
                panelbtn = panelbtnD;
                mainform = mainformD;
                postcolor = postcolorD;
                ffontco = ffontcoD;
                actcolor = actcolorD;
                hovcolor = hovcolorD;
                mode = modeD;
            }

            if (teme == "Light")
            {
                panelheader = panelheaderL;
                panelbtn = panelbtnL;
                mainform = mainformL;
                postcolor = postcolorL;
                ffontco = ffontcoL;
                actcolor = actcolorL;
                hovcolor = hovcolorL;
                mode = modeL;
            }

        }






    }

}
