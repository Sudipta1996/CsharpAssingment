using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //internal not accessable//
    //by default interface in private//
    //Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal or private protected.//
    public interface Iservice
    {
       void serve();
    }
    public class Service1 : Iservice
    {
        public void serve()
        {
            Console.WriteLine("Open a service");
        }
    }
    public class Service2 : Iservice
    {
        public void serve()
        {
            Console.WriteLine("Close a service");
        }
    }
    public class Client
    {
        private readonly Iservice _service;
        public Client(Iservice service)
        {
            _service = service;
        }
        public void serveMethod()
        {
            this._service.serve();
        }
    }
}
