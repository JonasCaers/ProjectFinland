using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFChildrenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }




        List<CHILDREN> IService1.GetAllChildren()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<CHILDREN> eenLijst = new List<CHILDREN>();

            var children = from row in dc.CHILDRENs
                           select row;

            foreach (var child in children)
            {
                CHILDREN kind = new CHILDREN();
                kind.ID = child.ID;
                kind.NAME = child.NAME;
                kind.USERNAME = child.USERNAME;
                kind.PASSWORD = child.PASSWORD;
                eenLijst.Add(kind);
            }

            return eenLijst;
        }
    }
}
