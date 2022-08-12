namespace GeneratorID
{
    internal class ImageE
    {
        #region Others Value
        private Bitmap temp_A4ID ; // A4 temp bitmap
        private int temp_A4IDint = 0; // A4 temp photos are on A4

        private int a4counter = 1; // how many a4 are saved
        #endregion
        #region Size
        private Size dimS = new Size(490, 325); // ID size
        public Size DimS
        {
            get { return dimS; }
            set { dimS = value; }
        }
        #endregion
        #region Fonts
        // Fonts
        private Font fontName = new Font("Cambria", 24.0f, FontStyle.Bold);
        public Font FontName
        {
            get { return fontName; }
            set { fontName = value; }
        }
        private Font fontSecondName = new Font("Cambria", 11.0f, FontStyle.Bold);
        public Font FontSecondName
        {
            get { return fontSecondName; }
            set { fontSecondName = value; }
        }
        private Font fontClas = new Font("Cambria", 37.0f, FontStyle.Bold);
        public Font FontClas
        {
            get { return fontClas; }
            set { fontClas = value; }

        }
        // End of Fonts
        #endregion
        #region Points
        // Text Points XY
        private Point pointName = new Point(230, 115); //Cords of name
        public Point PointName
        {
            get { return pointName; }
            set { pointName = value; }
        }
        private Point pointSecondName = new Point(240, 175); //Cords of second name
        public Point PointSecondName
        {
            get { return pointSecondName; }
            set { pointSecondName = value; Console.WriteLine("pointscN = " + pointSecondName.ToString()); }
        }
        private Point pointClass = new Point(388, 240); //Cords of class
        public Point PointClass
        {
            get { return pointClass; }
            set { pointClass = value; }
        }
        #endregion
        #region Data of Link & Cords

        private Point pointOfFirstID = new Point(10, 10); //XY of first ID cords
        public Point PointOfFirstID
        { get { return pointOfFirstID; } set { pointOfFirstID = value; } }

        private ushort idsCounter = 1; //counter - how many Id's is on A4 (f() below)
        private Point nextPoint()
        { // need update and mods 
            Point point;
            if (idsCounter == 9)
            {
                idsCounter = 1;
            }
            switch (idsCounter)
            {
                case 1:
                    point = PointOfFirstID;
                    break;
                case 2:
                    point = new Point(PointOfFirstID.X + whiteSpaceX + dimS.Width, PointOfFirstID.Y);
                    break;
                case 3:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + whiteSpaceY + dimS.Height);
                    break;
                case 4:
                    point = new Point(PointOfFirstID.X + whiteSpaceX + dimS.Width,/**/ PointOfFirstID.Y + whiteSpaceY + dimS.Height);
                    break;
                case 5:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 2);
                    break;
                case 6:
                    point = new Point(PointOfFirstID.X + whiteSpaceX + dimS.Width, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 2);
                    break;
                case 7:
                    point = new Point(PointOfFirstID.X, PointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 3);
                    break;
                case 8:
                    point = new Point(pointOfFirstID.X + whiteSpaceX + dimS.Width, pointOfFirstID.Y + (whiteSpaceY + dimS.Height) * 2);
                    break;
                default:
                    MessageBox.Show("Poop #1");
                    point = PointOfFirstID;
                    break;

            }
            idsCounter += 1;

            return point;
        } // I hate this f(), need many changes and improvement 


        private int whiteSpaceX = 2; // space X
        private int whiteSpaceY = 2; // space Y
        private int maxIdOnPage = 8; // at  this moment max is '8'
        #endregion

        public Bitmap GenA4()
        {
            float mmpi = 25.4f;
            int dpi = 150;
            Bitmap A4 = new Bitmap((int)(210 / mmpi * dpi), (int)(297 / mmpi * dpi));
            A4.SetResolution(dpi, dpi);
            return A4;
        } // Generate and return A4 Bitmap
        public Bitmap GenID(Image img, string name = "Imię", string secondName = "Nazwisko", string _class = "12")
        {
            try
            {
                Bitmap image = (Bitmap)img;

                Bitmap resized = new Bitmap(image, dimS);
                using (Graphics g = Graphics.FromImage(resized))
                {
                    //g.MeasureString(name, fontName);
                    //float WidthScaleRatio = Room.Width / RealSize.Width; 
                    g.DrawString(name, fontName, Brushes.Black, pointName);
                    g.DrawString(secondName, fontSecondName, Brushes.Black, pointSecondName);
                    g.DrawString(_class, fontClas, Brushes.Black, pointClass);
                }
                return resized;
            }
            catch
            {
                return (Bitmap)img;
            }
        } // Generate and return ID image with personals 
        public void LinkIDonA4(Bitmap bitmapId)
        {
            Bitmap a4;
            if (temp_A4IDint == 0)
            {
                 a4 = GenA4();
            }
            else
            {
                a4 = temp_A4ID;
            }

            using (Graphics g = Graphics.FromImage(a4))
            {
                Point point = nextPoint();
                g.DrawImage(bitmapId, point);
            }
            temp_A4IDint += 1;
            temp_A4ID = a4;
            if (temp_A4IDint == 8)
            {
                temp_A4ID.Save(@"C:\PamilProgramFiles\IDgen\Data\" + a4counter.ToString() + ".jpeg");
                temp_A4IDint = 0;
            }
        } //Link images in pattern on A4size image, and save if count of images go up to 8.

    }
}
