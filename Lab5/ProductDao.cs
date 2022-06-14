using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab5
{
    public interface ProductDao
    {
        public Hashtable getAll();
        public Hashtable createProduct(Product product);
        public Hashtable updateProduct(Product product);
        public Hashtable deleteProduct(Product product);
    }
}
