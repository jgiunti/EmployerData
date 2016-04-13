using MongoDB.Bson;

namespace EDAW.Data
{
    public class Employer
    {
        public ObjectId id;

        public string employerName { get; set; }
        public string state { get; set; }
        public string town { get; set; }
        public string city_country { get; set; }
        public int jobsec { get; set; }
        public int worklife { get; set; }
        public int workload { get; set; }
        public int careerpath { get; set; }
        public int td { get; set; }
        public int promo { get; set; }
        public int goodsup { get; set; }
        public int auton { get; set; }
        public int promocrit { get; set; }
        public int salary { get; set; }
        public int flex { get; set; }
        public int rewperf { get; set; }
        public int mission { get; set; }
        public int health { get; set; }
        public int rewrecog { get; set; }
        public int workspace { get; set; }
        public int poorperfs { get; set; }

        public Employer(string employerName, string state, string town, string city_country, int jobsec, int worklife, int workload, int careerpath, int td, int promo, int goodsup,
            int auton, int  promocrit, int salary, int flex, int repwerf, int mission, int health, int rewrecog, int workspace, int poorperfs)
        {
            this.employerName = employerName;
            this.state = state;
            this.town = town;
            this.city_country = city_country;
            this.jobsec = jobsec;
            this.worklife = worklife;
            this.workload = workload;
            this.careerpath = careerpath;
            this.td = td;
            this.promo = promo;
            this.goodsup = goodsup;
            this.auton = auton;
            this.promocrit = promocrit;
            this.salary = salary;
            this.flex = flex;
            this.rewperf = repwerf;
            this.mission = mission;
            this.health = health;
            this.rewrecog = rewrecog;
            this.workspace = workspace;
            this.poorperfs = poorperfs;
        }


        public Employer()
        {

        }

    }
}
