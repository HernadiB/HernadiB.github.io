using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    interface Piece
    {
        void setSzin(char szin);
        void setNev(char szin);
        bool setMozgas(ChessPiece[,] tabla, int jelenOszlop, int jelenSor, int kovetkezoOszlop, int kovetkezoSor);
        int getOsszesMozgas();
    }

}
