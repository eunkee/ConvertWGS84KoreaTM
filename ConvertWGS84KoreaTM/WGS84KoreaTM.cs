using System;

namespace ConvertWGS84KoreaTM
{
    internal class WGS84KoreaTM
    {
        [Flags]
        public enum Ellipsoid
        {
            Bessel = 0,
            GRS80 = 1
        }

        [Flags]
        public enum Origin
        {
            West = 0,
            Central = 1,
            East = 2,
            EastSea = 3,
            JejuIsland = 4
        }

        public static void TransGPS2M(Ellipsoid ellipsoid, Origin origin, double latitude, double longitude, out double x, out double y, bool originaddition = false)
        {
            double init_longitude = 127.0;
            if (origin == Origin.West)
            {
                init_longitude = 125.0;
            }
            else if (origin == Origin.East)
            {
                init_longitude = 129.0;
            }
            else if (origin == Origin.EastSea)
            {
                init_longitude = 131.0;
            }

            double init_latitude = 38.0;

            double false_east = 200000.0;
            double false_north = 500000.0;
            if (originaddition)
            {
                false_north = 600000.0;
            }
            else if (origin == Origin.JejuIsland)
            {
                false_north = 550000.0;
            }
            double a = 6377397.155;
            double f = 1.0 / 299.1528128;
            if (ellipsoid == Ellipsoid.GRS80)
            {
                a = 6378137;
                f = 1.0 / 298.257222101;
            }
            double b = a * (1 - f);
            double phi_0 = init_latitude * Math.PI / 180.0;
            double lambda_0 = init_longitude * Math.PI / 180.0;
            double e = (Math.Pow(a, 2.0) - Math.Pow(b, 2.0)) / Math.Pow(a, 2.0);
            double e2 = (Math.Pow(a, 2.0) - Math.Pow(b, 2.0)) / Math.Pow(b, 2.0);
            double M_0 = a * ((1.0 - e / 4 - 3.0 * Math.Pow(e, 2.0) / 64 - 5.0 * Math.Pow(e, 3.0) / 256.0) * phi_0
                                - (3.0 * e / 8.0 + 3.0 * Math.Pow(e, 2.0) / 32.0 + 45.0 * Math.Pow(e, 3.0) / 1024.0) * Math.Sin(2.0 * phi_0)
                                + (15.0 * Math.Pow(e, 2.0) / 256.0 + 45.0 * Math.Pow(e, 3.0) / 1024.0) * Math.Sin(4.0 * phi_0)
                                - (35.0 * Math.Pow(e, 3.0) / 3027.0) * Math.Sin(6.0 * phi_0));

            double phi = latitude * Math.PI / 180.0;
            double lambda = longitude * Math.PI / 180.0;
            double T = Math.Pow(Math.Tan(phi), 2.0);
            double C = (e / (1.0 - e)) * Math.Pow(Math.Cos(phi), 2.0);
            double A = (lambda - lambda_0) * Math.Cos(phi);
            double N = a / Math.Sqrt(1.0 - e * Math.Pow(Math.Sin(phi), 2.0));
            double M = a * ((1.0 - e / 4.0 - 3.0 * Math.Pow(e, 2.0) / 64.0 - 5.0 * Math.Pow(e, 3.0) / 256) * phi
                            - (3.0 * e / 8.0 + 3.0 * Math.Pow(e, 2.0) / 32.0 + 45.0 * Math.Pow(e, 3.0) / 1024.0) * Math.Sin(2.0 * phi)
                            + (15.0 * Math.Pow(e, 2.0) / 256.0 + 45.0 * Math.Pow(e, 3.0) / 1024.0) * Math.Sin(4.0 * phi)
                            - 35.0 * Math.Pow(e, 3.0) / 3072.0 * Math.Sin(6.0 * phi));
            x = false_north + (M - M_0 + N * Math.Tan(phi) * (Math.Pow(A, 2.0) / 2.0
                        + Math.Pow(A, 4.0) / 24.0 * (5.0 - T + 9.0 * C + 4.0 * Math.Pow(C, 2.0))
                        + Math.Pow(A, 6.0) / 720.0 * (61.0 - 58.0 * T + Math.Pow(T, 2.0) + 600.0 * C - 330.0 * e2)));
            y = false_east + N * (A + Math.Pow(A, 3.0) / 6.0 * (1.0 - T + C) +
                        Math.Pow(A, 5.0) / 120.0 * (5.0 - 18.0 * T + Math.Pow(T, 2.0) + 72.0 * C - 58.0 * e2));
        }

        public static void TransM2GPS(Ellipsoid ellipsoid, Origin origin, double x, double y, out double latitude, out double longitude, bool originaddition = false)
        {
            double init_longitude = 127.0;
            if (origin == Origin.West)
            {
                init_longitude = 125.0;
            }
            else if (origin == Origin.East)
            {
                init_longitude = 129.0;
            }
            else if (origin == Origin.EastSea)
            {
                init_longitude = 131.0;
            }

            double init_latitude = 38.0;
            double false_east = 200000.0;
            double false_north = 500000.0;
            if (originaddition)
            {
                false_north = 600000.0;
            }
            else if (origin == Origin.JejuIsland)
            {
                false_north = 550000.0;
            }

            double a = 6377397.155;
            double f = 1.0 / 299.1528128;
            if (ellipsoid == Ellipsoid.GRS80)
            {
                a = 6378137;
                f = 1.0 / 298.257222101;
            }
            double b = a * (1 - f);
            double phi_0 = init_latitude * Math.PI / 180.0;
            double e = (Math.Pow(a, 2.0) - Math.Pow(b, 2.0)) / Math.Pow(a, 2.0);
            double e2 = (Math.Pow(a, 2.0) - Math.Pow(b, 2.0)) / Math.Pow(b, 2.0);
            double M_0 = a * ((1.0 - e / 4 - 3.0 * Math.Pow(e, 2.0) / 64 - 5.0 * Math.Pow(e, 3.0) / 256.0) * phi_0
                                - (3.0 * e / 8.0 + 3.0 * Math.Pow(e, 2.0) / 32.0 + 45.0 * Math.Pow(e, 3.0) / 1024.0) * Math.Sin(2.0 * phi_0)
                                + (15.0 * Math.Pow(e, 2.0) / 256.0 + 45.0 * Math.Pow(e, 3.0) / 1024.0) * Math.Sin(4.0 * phi_0)
                                - (35.0 * Math.Pow(e, 3.0) / 3027.0) * Math.Sin(6.0 * phi_0));

            double e1 = (1.0 - Math.Sqrt(1.0 - e)) / (1.0 + Math.Sqrt(1.0 - e));
            double M = M_0 + (x - false_north);
            double mu = M / (a * (1.0 - e / 4.0 - 3 * Math.Pow(e, 2.0) / 64.0 - 5.0 * Math.Pow(e, 3.0) / 256.0));
            double phi = mu + (3.0 * e1 / 2.0 - 27.0 * Math.Pow(e1, 3.0) / 32.0) * Math.Sin(2.0 * mu)
                        + (21.0 * Math.Pow(e1, 2.0) / 16.0 - 55.0 * Math.Pow(e1, 4.0) / 32.0) * Math.Sin(4.0 * mu)
                        + (151.0 * Math.Pow(e1, 3.0) / 96.0) * Math.Sin(6.0 * mu) + (1097.0 * Math.Pow(e1, 4.0) / 512.0) * Math.Sin(8.0 * mu);
            double R1 = (a * (1 - e)) / Math.Pow(Math.Sqrt(1.0 - e * Math.Pow(Math.Sin(phi), 2.0)), 3.0);
            double C1 = e2 * Math.Pow(Math.Cos(phi), 2.0);
            double T1 = Math.Pow(Math.Tan(phi), 2.0);
            double N1 = a / Math.Sqrt(1.0 - e * Math.Pow(Math.Sin(phi), 2.0));
            double D = (y - false_east) / N1;
            latitude = (phi - (N1 * Math.Tan(phi) / R1) * (Math.Pow(D, 2.0) / 2.0
                            - Math.Pow(D, 4.0) / 24.0 * (5.0 + 3.0 * T1 + 10.0 * C1 - 4.0 * Math.Pow(C1, 2.0) - 9.0 * e2)
                            + Math.Pow(D, 6.0) / 720.0 * (61.0 + 90.0 * T1 + 298.0 * C1 + 45.0 * Math.Pow(T1, 2.0) - 252.0 * e2
                            - 3.0 * Math.Pow(C1, 2.0)))) * 180.0 / Math.PI;
            longitude = init_longitude + ((1.0 / Math.Cos(phi)) * (D - (Math.Pow(D, 3.0) / 6.0) * (1.0 + 2.0 * T1 + C1)
                            + (Math.Pow(D, 5.0) / 120.0) * (5.0 - 2.0 * C1 + 28.0 * T1 - 3.0 * Math.Pow(C1, 2.0)
                            + 8.0 * e2 + 24.0 * Math.Pow(T1, 2.0)))) * 180.0 / Math.PI;
        }
    }
}