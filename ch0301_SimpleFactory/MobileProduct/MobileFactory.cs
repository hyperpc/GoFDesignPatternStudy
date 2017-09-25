using System;

namespace MobileProduct
{
    class MobileFactory
    {
        public IMobile GetMobile(string title)
        {
            try
            {
                if (title.ToLower().Equals("nokia"))
                    return new Nokia();

                if (title.ToLower().Equals("motorola"))
                    return new Motorola();

                Console.WriteLine(string.Format("No such {0} mobile found", title));
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("No such {0} mobile found", title));
                Console.WriteLine(string.Format("With exception : \n{0}\n{1}", ex.Message, ex.StackTrace));
                return null;
            }
        }
    }
}
