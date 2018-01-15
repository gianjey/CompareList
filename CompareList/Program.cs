using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareList
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito dep1 = new Deposito(new DateTime(2014, 1, 16), "desc1");
            Deposito dep2 = new Deposito(new DateTime(2014, 1, 17), "desc2");
            Deposito dep3 = new Deposito(new DateTime(2014, 1, 17), "desc2");
            Deposito dep4 = new Deposito(new DateTime(2014, 1, 18), "desc4");
            Deposito dep5 = new Deposito(new DateTime(2014, 1, 18), "desc4");

            List<Deposito> depsDb = new List<Deposito> { dep1, dep2, dep3 };
            List<Deposito> depsSiecic = new List<Deposito> { dep1, dep2, dep3, dep4, dep5 };

            var dbNotSiecic = depsDb.Except(depsSiecic).ToList();
            var siecicNotDb = depsSiecic.Except(depsDb).ToList();

        }
    }

    public class Deposito
    {
        protected DateTime dataDeposito;
        protected string descDeposito;

        public Deposito(DateTime dataDeposito, string descDeposito)
        {
            this.dataDeposito = dataDeposito;
            this.descDeposito = descDeposito;
        }
    }
}
