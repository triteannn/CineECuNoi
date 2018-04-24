using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository{
    /**
     * 
     */
    public interface ISQLRepo<T, I> {

        /**
         * @param entity 
         * @return
         */
        void Add(T entity);

        /**
         * @param entity 
         * @return
         */
        T Delete(T entity);

        /**
         * @param entity 
         * @return
         */
        T Update(T entity);

        /**
         * @param id 
         * @return
         */
        T FindEntity(I id);

        /**
         * @return
         */
        List<T> FindAll();

    }
}