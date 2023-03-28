using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu
{
    class PooledObject
    {
        FrmMain M = new FrmMain();
        FrmLich L = new FrmLich();
        FrmBaoCao B = new FrmBaoCao();

        List<PooledObject> objectPool = new List<PooledObject>();
        public void InitializePool(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PooledObject obj = new PooledObject();
                // Khởi tạo đối tượng theo nhu cầu
                objectPool.Add(obj);
            }
        }
        public PooledObject GetObjectFromPool()
        {
            if (objectPool.Count > 0)
            {
                PooledObject obj = objectPool[0];
                objectPool.RemoveAt(0);
                // Thiết lập lại đối tượng theo nhu cầu
                return obj;
            }
            else
            {
                PooledObject obj = new PooledObject();
                // Khởi tạo đối tượng theo nhu cầu
                return obj;
            }
        }
        public void ReturnObjectToPool(PooledObject obj)
        {
            // Thiết lập lại đối tượng theo nhu cầu
            objectPool.Add(obj);
        }
    }
}
