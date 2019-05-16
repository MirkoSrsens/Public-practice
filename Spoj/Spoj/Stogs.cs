using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj
{
    public class Stogs
    {
        public int Number { get; set; }

        public bool Unknown { get; set; }

        public Stogs Link { get; set; }

        public static Stogs Plus(Stogs lh, Stogs rh)
        {
            if (lh.Unknown)
            {
                if(lh.Link == null)
                {
                    lh.Link = rh;
                }
                else
                {
                    lh.Link.Number += rh.Number;
                }
                lh.Unknown = true;

                return lh;
            }
            else if(rh.Unknown)
            {
                if (rh.Link == null)
                {
                    rh.Link = lh;
                }
                else
                {
                    rh.Link.Number += lh.Number;
                }
                rh.Unknown = true;

                return rh;
            }
            else
            {
                return new Stogs()
                {
                    Number = lh.Number + rh.Number,
                    Unknown = false
                };
            }
        }

        public static Stogs Minus(Stogs lh, Stogs rh)
        {
            if (lh.Unknown)
            {
                if(lh.Link == null)
                {
                    lh.Link = rh;
                    lh.Link.Number *= -1;
                }
                else
                {
                    lh.Link.Number -= rh.Number;
                }
                lh.Unknown = true;
                return lh;
            }
            else if (rh.Unknown)
            {
                if(rh.Link == null)
                {
                    rh.Link = lh;
                }
                else
                {
                    rh.Link.Number = lh.Number - rh.Link.Number;
                }
                rh.Unknown = true;
                rh.Number *= -1;
                return rh;
            }
            else
            {
                return new Stogs()
                {
                    Number = lh.Number - rh.Number,
                    Unknown = false
                };
            }
        }

        public static Stogs Multiply(Stogs lh, Stogs rh)
        {
            if(lh.Unknown)
            {
                lh.Number *= rh.Number;

                if(lh.Link != null)
                {
                    lh.Link.Number *= rh.Number;
                }

                return lh;
            }
            else if (rh.Unknown)
            {
                rh.Number *= lh.Number;

                if (rh.Link != null)
                {
                    rh.Link.Number *= lh.Number;
                }

                return rh;
            }
            else
            {
                return new Stogs()
                {
                    Number = rh.Number * lh.Number,
                    Unknown = false,
                    Link = null
                };
            }
        }
    }
}
