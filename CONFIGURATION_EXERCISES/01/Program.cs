using _01.DbContexts;
using System;
using System.Linq;


namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var DbCtx = new DbContextMPR();
            var mpList = DbCtx.MEAUSERMENT_POINTS.FirstOrDefault(x => x.CODE == "....");
        }
    }
}
