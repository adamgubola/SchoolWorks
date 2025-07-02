using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GubolaAdam_D0JE27_ZH2
{
    public class Osszetevok
    {
        private string name;
        private int amount;
        private OsszetevoFajta osszetevoFajta;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public int Amount
        {
            get { return amount; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value.ToString()))
                    amount = value;
            }
        }

        public OsszetevoFajta OsszetevoFajta
        {
            get { return osszetevoFajta; }
            set
            {
                osszetevoFajta = value;
            }
        }

        public Osszetevok(string osszetevoFajta, string name, string amount)
        {
            if (!string.IsNullOrWhiteSpace(osszetevoFajta))
            {
                this.osszetevoFajta = (OsszetevoFajta)Enum.Parse(typeof(OsszetevoFajta), osszetevoFajta);
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                this.name = name;
            }

            if (!string.IsNullOrWhiteSpace(amount))
            {
                this.amount = int.Parse(amount);
            }
        }

        public Osszetevok(string[] datas) : this(datas[0], datas[1], datas[2])
        {
        }

        public Osszetevok(string data) : this(data.Split(','))
        {
        }

        public string Szovegkent()
        {
            return $"{this.osszetevoFajta} {name} ({amount}) ml";
        }
    }
}