using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFac.Data;
using AutoFac.Models;
using Autofac;

namespace AutoFacTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterModule(new Autofac.Configuration.ConfigurationSettingsReader("autofac"));
            ////builder.RegisterType<DBBase>();
            ////builder.RegisterType<SqlRepository>().As<IRepository>();

            //using (IContainer container = builder.Build())
            //{
            //    var manager = container.Resolve<DBBase>();
            //    manager.Search("select * from tb!");
            //}
            AutoMapperTest.Configure();
            BookDto book = AutoMapperTest.ToBookDto();
            

            Console.ReadKey();
        }
    }
}
