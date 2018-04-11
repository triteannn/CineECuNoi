using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace Repository{
    /**
     * 
     */
    public class SQLDonatorRepo : ISQLRepo<Donator> {

        /**
         * 
         */
        public SQLDonatorRepo() {}

        /**
         * @param donator 
         * @return
         */
        public void Add(Donator donator) {
            // TODO implement here
        }

        /**
         * @param donator 
         * @return
         */
        public Donator Delete(Donator donator) {
            // TODO implement here
            return null;
        }

        /**
         * @param donator 
         * @return
         */
        public Donator Update(Donator donator) {
            // TODO implement here
            return null;
        }

        /**
         * @param id 
         * @return
         */
        public Donator FindEntity(int id) {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public List<Donator> FindAll() {
            // TODO implement here
            return null;
        }

    }
}