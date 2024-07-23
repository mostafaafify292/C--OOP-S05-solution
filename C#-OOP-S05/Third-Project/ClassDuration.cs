using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_S05.Third_Project
{
    internal class Duration
    {
        public int Hours {  get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
            
        }

        public Duration(int _H ,int _M ,int _S)
        {
            Hours = _H;
            Minutes = _M;
            Seconds = _S;
        }
        public Duration(int _S) 
        {
            Seconds = _S;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            ////condation if the user input is (second) like Duration D1 =new Duration (3600) ;)  

            if (this.Seconds >= 60)
            {

                if (this.Seconds % 60 == 0)
                {
                    int x;
                    x = this.Seconds / 60;
                    this.Minutes = x;
                    this.Seconds = 0;

                    if (this.Minutes >= 60)
                    {
                        if (this.Minutes % 60 == 0)
                        {

                            x = this.Minutes / 60;
                            this.Hours = x;
                            this.Minutes = 0;

                        }
                        else if (this.Minutes % 60 != 0)
                        {
                            x = (int)this.Minutes / 60;
                            this.Hours = x;
                            int y;
                            y = this.Minutes % 60;
                            this.Minutes = y;


                        }

                    }
                    return $" ( Hours = {this.Hours} , Minutes {this.Minutes} , Seconds = {this.Seconds} )  ";
                }
                else if (this.Seconds % 60 != 0)
                {
                    int x;
                    x = (int)this.Seconds / 60;
                    this.Minutes = x;
                    int y;
                    y = this.Seconds % 60;
                    this.Seconds = y;

                    if (this.Minutes >= 60)
                    {
                        if (this.Minutes % 60 == 0)
                        {
                            int z;
                            z = this.Minutes / 60;
                            this.Hours = z;
                            this.Minutes = 0;
                        }
                        else if (this.Minutes % 60 != 0)
                        {
                            int b = (int)this.Minutes / 60;
                            this.Hours = b;
                            int z;
                            z = this.Minutes % 60;
                            this.Minutes = z;
                        }
                    }

                }
                return $" ( Hours = {this.Hours} , Minutes {this.Minutes} , Seconds = {this.Seconds} )  ";
            }


            else
                return $"( Hours = {Hours} , Minutes = {Minutes} , Seconds = {Seconds} ) ";

        }
        
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds,

            };


        }
        
        #region overload on + operator to can make (d3 = d1 + 7800)
        public static Duration operator +(Duration left, int sec)
        {
            Duration test = new Duration(sec);
            test.ToString();

            return new Duration()
            {
                Hours = test.Hours + left.Hours,
                Minutes = test.Minutes + left.Minutes,
                Seconds = test.Seconds + left.Seconds,

            };


        } 
        #endregion
        public static Duration operator ++(Duration duration) 
        {
            return new Duration()
            {
                Hours = duration.Hours ,
                Minutes = duration.Minutes + 1,
                Seconds = duration.Seconds ,

            };
        
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration()
            {
                Hours = duration.Hours,
                Minutes = duration.Minutes - 1,
                Seconds = duration.Seconds,

            };

        }
        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours - right.Hours,
                Minutes = left.Minutes - right.Minutes,
                Seconds = left.Seconds - right.Seconds,

            };


        }
        public static bool operator > (Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (left.Seconds == right.Seconds)
                    {
                        return left.Seconds > right.Seconds;
                    }
                    else
                    {
                        return left.Seconds > right.Seconds;
                    }

                }
                else
                {
                    return left.Minutes > right.Minutes;
                }
            }
            else
            { return left.Hours > right.Hours; }

        }      
        public static bool operator < (Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (left.Seconds == right.Seconds)
                    {
                        return left.Seconds < right.Seconds;
                    }
                    else
                    {
                        return left.Seconds < right.Seconds;
                    }

                }
                else
                {
                    return left.Minutes < right.Minutes;
                }
            }
            else
            { return left.Hours < right.Hours; }

        }
        public static bool operator <= (Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (left.Seconds == right.Seconds)
                    {
                        return left.Seconds == right.Seconds;
                    }
                    else
                    {
                        return left.Seconds <= right.Seconds;
                    }

                }
                else
                {
                    return left.Minutes <= right.Minutes;
                }
            }
            else
            { return left.Hours <= right.Hours; }

        }
        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (left.Seconds == right.Seconds)
                    {
                        return left.Seconds == right.Seconds;
                    }
                    else
                    {
                        return left.Seconds >= right.Seconds;
                    }

                }
                else
                {
                    return left.Minutes >= right.Minutes;
                }
            }
            else
            { return left.Hours >= right.Hours; }

        }


    }
}

