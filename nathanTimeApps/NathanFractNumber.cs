using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nathanTimeApps
{
    public class NathanFractNumber
    {
        #region FIELDS
        private int _numerator, _denomirator;
        #endregion

        #region CONSTRUCTOR
        public NathanFractNumber()
        {
            this._numerator = 0;
            this._denomirator = 1;
        }

        public NathanFractNumber(int numerator, int denomerator)
        {
            this._numerator = numerator;
            this._denomirator = denomerator;
        }

        public NathanFractNumber(NathanFractNumber fract)
        {
            this._numerator = fract.Numerator;
            this._denomirator = fract.Denomirator;
        }
        #endregion

        #region PROPERTIES
        public int Numerator { get => _numerator; set => _numerator = value; }
        public int Denomirator 
        { 
            get => _denomirator; 
            set
            {
                if (value != 0)
                {
                    _denomirator = value;
                }
                else
                {
                    throw new ArgumentException("Denomerator cant be zero");
                }
            }
        }
        #endregion

        #region METHODS
        
        public NathanFractNumber Multiply(NathanFractNumber fract2)
        {
            NathanFractNumber resultFract = new NathanFractNumber();
            resultFract.Numerator = this.Numerator * fract2.Numerator;
            resultFract.Denomirator = this.Denomirator * fract2.Denomirator;

            return resultFract;
        }

        public NathanFractNumber Division(NathanFractNumber fract2)
        {
            NathanFractNumber resultFract = new NathanFractNumber();
            resultFract.Numerator = this.Numerator * fract2.Denomirator;
            resultFract.Denomirator = this.Denomirator * fract2.Numerator;

            return resultFract;
        }

        public NathanFractNumber Add(NathanFractNumber fract2)
        {
            NathanFractNumber resultFract = new NathanFractNumber();

            NathanFractNumber copy1 = new NathanFractNumber(this);
            NathanFractNumber copy2 = new NathanFractNumber(fract2);

            copy1.Numerator *= copy2.Denomirator;
            copy1.Denomirator *= fract2.Denomirator;

            copy2.Numerator *= this.Denomirator;
            copy2.Denomirator *= this.Denomirator;

            resultFract.Numerator = copy1.Numerator + copy2.Numerator;
            resultFract.Denomirator = copy1.Denomirator;

            return resultFract;
        }

        public NathanFractNumber Subtraction(NathanFractNumber fract2)
        {
            NathanFractNumber resultFract = new NathanFractNumber();

            NathanFractNumber copy1 = new NathanFractNumber(this);
            NathanFractNumber copy2 = new NathanFractNumber(fract2);

            copy1.Numerator *= copy2.Denomirator;
            copy1.Denomirator *= fract2.Denomirator;

            copy2.Numerator *= this.Denomirator;
            copy2.Denomirator *= this.Denomirator;

            resultFract.Numerator = copy1.Numerator - copy2.Numerator;
            resultFract.Denomirator = copy1.Denomirator;

            return resultFract;
        }
        
        #endregion
    }
}
