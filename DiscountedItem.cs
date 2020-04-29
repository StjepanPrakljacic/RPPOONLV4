using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class DiscountedItem:RentableDecorator
    {
        private  double Discount_percentage;
        public DiscountedItem(IRentable rentable, double value) : base(rentable) { this.Discount_percentage = value; }
        public double SetDiscount_percentage(double value)
        {
           return this.Discount_percentage = value;
        }
        public double GetDiscount_percentage()
        {
            return this.Discount_percentage;
        }
        public override double CalculatePrice()
        {
            return (base.CalculatePrice() - (base.CalculatePrice()*(this.Discount_percentage/100)));
        }
        public override String Description
        {
            get
            {
                return "Trending: " + base.Description;
            }
        }

    }
}
