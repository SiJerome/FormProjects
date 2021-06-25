using System;
using System.Collections;

namespace DataHelper
{
    public class DataAccess
    {
        string[] prdid = {"PRN", "MSE", "PRNDT", "MNTRLE"};
        string[] prdname = {"Printer Laser", "Mouse", "Printer Dot Matrix", "LCD Monitor"};
        string[] prdquantity = {"100","100","100","100"};

        ArrayList productid = new ArrayList();
        ArrayList productname = new ArrayList();
        ArrayList productquantity = new ArrayList();

        int mouse = 575, printerlaser = 8050, printerdot = 8625, lcd = 7475;

        int srp;
        int amount;
        int quantity;
        int totalamount;
        int newstock;

        public void ComputeProduct(int productname, int inputquantity)
        {
            
            
            switch (productname)
            {
                case 1:
                    srp = Printerlaser;
                    quantity = inputquantity;
                    amount = srp * quantity;
                    totalamount = totalamount + amount;
                    break;
                case 2:
                    srp = Mouse;
                    quantity = inputquantity;
                    amount = srp * quantity;
                    totalamount = totalamount + amount;
                    break;
                case 3:
                    srp = Printerdot;
                    quantity = inputquantity;
                    amount = srp * quantity;
                    totalamount = totalamount + amount;
                    break;
                case 4:
                    srp = Lcd;
                    quantity = inputquantity;
                    amount = srp * quantity;
                    totalamount = totalamount + amount;
                    break;
            }

        }
        public void UpdateQuantity(int qty, int n)
        {
            Newstock = Convert.ToInt32(Productquantity[n]) - qty;
            Productquantity[n] = Newstock.ToString();
            
            if(Newstock < 0)
            {
                Newstock = 0;
            }
        }

        public DataAccess()
         {
            int elements = prdid.Length;
            for(int i = 0; i < elements; i++)
            {
                Productid.Add(prdid[i]);
                Productname.Add(prdname[i]);
                Productquantity.Add(prdquantity[i]);

            }

        }
        ~DataAccess()
        {

        }

        public ArrayList Productid { get => productid; set => productid = value; }
        public ArrayList Productname { get => productname; set => productname = value; }
        public ArrayList Productquantity { get => productquantity; set => productquantity = value; }
        public int Srp { get => srp; set => srp = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Totalamount { get => totalamount; set => totalamount = value; }
        public int Mouse { get => mouse; set => mouse = value; }
        public int Printerlaser { get => printerlaser; set => printerlaser = value; }
        public int Printerdot { get => printerdot; set => printerdot = value; }
        public int Lcd { get => lcd; set => lcd = value; }
        public int Newstock { get => newstock; set => newstock = value; }
    }
}
