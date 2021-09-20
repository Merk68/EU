using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
  class Class1
  {
    private string orszag;

    public string Orszag
    {
      get { return orszag; }
      set { orszag = value; }
    }

    private DateTime csatlakozas;

    public DateTime Csatlakozas
    {
      get { return csatlakozas; }
      set { csatlakozas = value; }
    }

    public Class1(string orszag, DateTime csatlakozas)
    {
      this.orszag = orszag;
      this.csatlakozas = csatlakozas;
    }
  }
}
