﻿using ClassBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//--------------------------- C# Chess Board 10 gui controls -------------------------------------------------
//ref link:https://www.youtube.com/watch?v=cTNtnS6BSN0&list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF&index=10&t=1s

// add label(Prop:Text:Select a piece from the drop down menu.....), comboBox(Prop:items->...->Bishop/Rook...), Panel(Prop:SizeWidth500Height500),Form1(Prop:Text:Chess Piece Moves)

//--------------------------- C# Chess Board 11 placebuttons ---------------------------------------------
//ref link:https://www.youtube.com/watch?v=f3QRYl3o5Ak&list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF&index=11

//

namespace C__Chess_Board_10
{
    public partial class Form1 : Form
    {
        //------------START------------ C# Chess Board 11 placebuttons ---------------------------------------------
        Board myBoard = new Board(8);
        //-------------END------------ C# Chess Board 11 placebuttons ---------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }
    }
}
