using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.Models.Accounts
{
    public class Identity
    {
    }
    public enum Identifier
    {
        Email = 1, Phone = 2 , OAuth = 3

    }

    public enum OAuth
    {
        Facebook = 1, Google = 2 , Microsoft = 3

    }
    public struct ConvertEnum2
    {
        public int Value
        {
            get;
            set;
        }
        public String Text
        {
            get;
            set;
        }
    }
}
