using System.Collections.Generic;
using DTO;

namespace ProjectWedding
{
    internal class DataBindings
    {
        private string empty;
        private List<FSanh_DTO> listKieuNau;

        public DataBindings(List<FSanh_DTO> listKieuNau, string empty)
        {
            this.listKieuNau = listKieuNau;
            this.empty = empty;
        }
    }
}