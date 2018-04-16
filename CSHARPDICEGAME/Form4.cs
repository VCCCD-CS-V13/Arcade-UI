

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form4 : Form
    {
        bool turn = true; //true = X turn, false = O turn
        int draw = 0; //if draw ever reaches 9, then game is a draw.
        int A_Block_Draw = 0, B_Block_Draw = 0, C_Block_Draw = 0, D_Block_Draw = 0, E_Block_Draw = 0,//make draw counts for each individual block
                F_Block_Draw = 0, G_Block_Draw = 0, H_Block_Draw = 0, I_Block_Draw = 0;              //if block draw count ever reaches 9 and no winner declared,
                                                                                                     //these counts should reset to 0 corrisponding to 
                                                                                                     //their block with Block_Draw function
        string Player1, Player2;
        public Form4()
            : this("","")
        { }

        public Form4(string Player1, string Player2)
        {
            InitializeComponent();
            this.Player1 = Player1;
            this.Player2 = Player2;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) //toolstrip MAKES NEW GAME
        {
            turn = true; //CHANGE BACK TO X'S TURN      ///REMEMBER!/// "TURN" IS X'S TURN, "!TURN" IS O'S TURN


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c; //CLEAR AND ENABLE ALL BUTTONS
                    b.Enabled = turn;
                    b.Text = "";

                }
                catch { }
            }
            lbl_A_Block.Text = "";
            lbl_B_Block.Text = "";
            lbl_C_Block.Text = "";
            lbl_D_Block.Text = "";
            lbl_E_Block.Text = "";
            lbl_F_Block.Text = "";
            lbl_G_Block.Text = "";
            lbl_H_Block.Text = "";
            lbl_I_Block.Text = "";

            lbl_A_Block.Visible = false;
            lbl_B_Block.Visible = false;
            lbl_C_Block.Visible = false;
            lbl_D_Block.Visible = false;
            lbl_E_Block.Visible = false;
            lbl_F_Block.Visible = false;
            lbl_G_Block.Visible = false;
            lbl_H_Block.Visible = false;
            lbl_I_Block.Visible = false;

            A_Block_Draw = 0;
            B_Block_Draw = 0;
            C_Block_Draw = 0;
            D_Block_Draw = 0;
            E_Block_Draw = 0;
            F_Block_Draw = 0;
            G_Block_Draw = 0;
            H_Block_Draw = 0;
            I_Block_Draw = 0;

            draw = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)//toolsrip info
        {
            MessageBox.Show("By Alden Smith, Ultimate Tic Tac Toe, Working 11/28/17");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //toolstrip exit
        {
            new CSHARPDICEGAME.Form3().Show();
            this.Hide();
        }

        private void Button_Enter(object sender, EventArgs e) //MAKE BUTTON SHOW WHOS NEXT
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
        }

        private void Button_Leave(object sender, EventArgs e) //^^^^^^^^^^
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }//END SHOW WHOS NEXT

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e) //RESET SCORE
        {
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void Abutton_click(object sender, EventArgs e) //A BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            A_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Bbutton_click(object sender, EventArgs e) //B BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            B_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Cbutton_click(object sender, EventArgs e) //C BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            C_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Dbutton_click(object sender, EventArgs e) //D BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            D_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Ebutton_click(object sender, EventArgs e)//E BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            E_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Fbutton_click(object sender, EventArgs e)//F BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            F_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Gbutton_click(object sender, EventArgs e) //G BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            G_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Hbutton_click(object sender, EventArgs e)//H BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            H_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();
            
        }

        private void Ibutton_click(object sender, EventArgs e) //I BLOCK BUTTONS
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }


            turn = !turn;
            b.Enabled = false;
            I_Block_Draw++;
            checkForBlockWinner();
            checkForWinner();                                   
            
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void checkForBlockWinner()
        {
            //////////////////////////////////////////////////////////////////////////////////////BLOCK A
            bool A_block_Winner = false;
            //Block A Check
            if (((AA1.Text == AA2.Text) && (AA2.Text == AA3.Text) && (!AA1.Enabled) && (!lbl_A_Block.Visible)) //HORIZONTAL CHECKS
                || ((AB1.Text == AB2.Text) && (AB2.Text == AB3.Text) && (!AB1.Enabled) && (!lbl_A_Block.Visible))//
                || ((AC1.Text == AC2.Text) && (AC2.Text == AC3.Text) && (!AC1.Enabled) && (!lbl_A_Block.Visible))//END HORIZONTAL CHECKS
                || ((AA1.Text == AB1.Text) && (AB1.Text == AC1.Text) && (!AA1.Enabled) && (!lbl_A_Block.Visible))//VERTICAL CHECKS
                || ((AA2.Text == AB2.Text) && (AB2.Text == AC2.Text) && (!AA2.Enabled) && (!lbl_A_Block.Visible))//
                || ((AA3.Text == AB3.Text) && (AB3.Text == AC3.Text) && (!AA3.Enabled) && (!lbl_A_Block.Visible))//END VERTICAL CHECKS
                || ((AA1.Text == AB2.Text) && (AB2.Text == AC3.Text) && (!AA1.Enabled) && (!lbl_A_Block.Visible))//-DIAGONAL CHECKS-
                || ((AA3.Text == AB2.Text) && (AB2.Text == AC1.Text) && (!AA3.Enabled) && (!lbl_A_Block.Visible)))//-END DIAGONAL CHECKS-
            
                A_block_Winner = true;
                
            


            if (A_block_Winner)
            {
                String Ablock_Winner = "";
                if (turn)
                {
                    Ablock_Winner = "O";
                }
                else
                {
                    Ablock_Winner = "X";
                }
                lbl_A_Block.Text = Ablock_Winner;
                lbl_A_Block.Visible = true;
                draw++;

            }
            
            if ((A_Block_Draw == 9) && (!A_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                AA1.Text = "";
                AA2.Text = "";
                AA3.Text = "";
                AB1.Text = "";
                AB2.Text = "";
                AB3.Text = "";
                AC1.Text = "";                                                              /////MAKE ALL INTO VOID
                AC2.Text = "";
                AC3.Text = "";
                AA1.Enabled = true;
                AA2.Enabled = true;
                AA3.Enabled = true;
                AB1.Enabled = true;
                AB2.Enabled = true;
                AB3.Enabled = true;
                AC1.Enabled = true;
                AC2.Enabled = true;
                AC3.Enabled = true;
                A_Block_Draw -= 9;
                
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////B BLOCK
            bool B_block_Winner = false;
            //Block B Check
            if (((BA1.Text == BA2.Text) && (BA2.Text == BA3.Text) && (!BA1.Enabled) && (!lbl_B_Block.Visible)) //HORIZONTAL CHECKS
                || ((BB1.Text == BB2.Text) && (BB2.Text == BB3.Text) && (!BB1.Enabled) && (!lbl_B_Block.Visible))//
                || ((BC1.Text == BC2.Text) && (BC2.Text == BC3.Text) && (!BC1.Enabled) && (!lbl_B_Block.Visible))//END HORIZONTAL CHECKS
                || ((BA1.Text == BB1.Text) && (BB1.Text == BC1.Text) && (!BA1.Enabled) && (!lbl_B_Block.Visible))//VERTICAL CHECKS
                || ((BA2.Text == BB2.Text) && (BB2.Text == BC2.Text) && (!BA2.Enabled) && (!lbl_B_Block.Visible))//
                || ((BA3.Text == BB3.Text) && (BB3.Text == BC3.Text) && (!BA3.Enabled) && (!lbl_B_Block.Visible))//END VERTICAL CHECKS
                || ((BA1.Text == BB2.Text) && (BB2.Text == BC3.Text) && (!BA1.Enabled) && (!lbl_B_Block.Visible))//-DIAGONAL CHECKS-
                || ((BA3.Text == BB2.Text) && (BB2.Text == BC1.Text) && (!BA3.Enabled) && (!lbl_B_Block.Visible)))//-END DIAGONAL CHECKS-

                B_block_Winner = true;


            if ((B_block_Winner) && (!lbl_B_Block.Visible))
            {
                String Bblock_Winner = "";
                if (turn)
                {
                    Bblock_Winner = "O";
                }
                else
                {
                    Bblock_Winner = "X";
                }
                lbl_B_Block.Text = Bblock_Winner;
                lbl_B_Block.Visible = true;
                draw++;

            }
            if ((B_Block_Draw == 9) && (!B_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                BA1.Text = "";
                BA2.Text = "";
                BA3.Text = "";
                BB1.Text = "";
                BB2.Text = "";
                BB3.Text = "";
                BC1.Text = "";
                BC2.Text = "";
                BC3.Text = "";
                BA1.Enabled = true;
                BA2.Enabled = true;
                BA3.Enabled = true;
                BB1.Enabled = true;
                BB2.Enabled = true;
                BB3.Enabled = true;
                BC1.Enabled = true;
                BC2.Enabled = true;
                BC3.Enabled = true;
                B_Block_Draw -= 9;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////C BLOCK
            bool C_block_Winner = false;
            //Block C Check
            if (((CA1.Text == CA2.Text) && (CA2.Text == CA3.Text) && (!CA1.Enabled) && (!lbl_C_Block.Visible)) //HORIZONTAL CHECKS
                || ((CB1.Text == CB2.Text) && (CB2.Text == CB3.Text) && (!CB1.Enabled) && (!lbl_C_Block.Visible))//
                || ((CC1.Text == CC2.Text) && (CC2.Text == CC3.Text) && (!CC1.Enabled) && (!lbl_C_Block.Visible))//END HORIZONTAL CHECKS
                || ((CA1.Text == CB1.Text) && (CB1.Text == CC1.Text) && (!CA1.Enabled) && (!lbl_C_Block.Visible))//VERTICAL CHECKS
                || ((CA2.Text == CB2.Text) && (CB2.Text == CC2.Text) && (!CA2.Enabled) && (!lbl_C_Block.Visible))//
                || ((CA3.Text == CB3.Text) && (CB3.Text == CC3.Text) && (!CA3.Enabled) && (!lbl_C_Block.Visible))//END VERTICAL CHECKS
                || ((CA1.Text == CB2.Text) && (CB2.Text == CC3.Text) && (!CA1.Enabled) && (!lbl_C_Block.Visible))//-DIAGONAL CHECKS-
                || ((CA3.Text == CB2.Text) && (CB2.Text == CC1.Text) && (!CA3.Enabled) && (!lbl_C_Block.Visible)))//-END DIAGONAL CHECKS-

                C_block_Winner = true;


            if (C_block_Winner)
            {
                String Cblock_Winner = "";
                if (turn)
                {
                    Cblock_Winner = "O";
                }
                else
                {
                    Cblock_Winner = "X";
                }
                lbl_C_Block.Text = Cblock_Winner;
                lbl_C_Block.Visible = true;
                draw++;

            }

            if ((C_Block_Draw == 9) && (!C_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                CA1.Text = "";
                CA2.Text = "";
                CA3.Text = "";
                CB1.Text = "";
                CB2.Text = "";
                CB3.Text = "";
                CC1.Text = "";
                CC2.Text = "";
                CC3.Text = "";
                CA1.Enabled = true;
                CA2.Enabled = true;
                CA3.Enabled = true;
                CB1.Enabled = true;
                CB2.Enabled = true;
                CB3.Enabled = true;
                CC1.Enabled = true;
                CC2.Enabled = true;
                CC3.Enabled = true;
                C_Block_Draw -= 9;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////D BLOCK
            bool D_block_Winner = false;
            //Block D Check
            if (((DA1.Text == DA2.Text) && (DA2.Text == DA3.Text) && (!DA1.Enabled) && (!lbl_D_Block.Visible)) //HORIZONTAL CHECKS
                || ((DB1.Text == DB2.Text) && (DB2.Text == DB3.Text) && (!DB1.Enabled) && (!lbl_D_Block.Visible))//
                || ((DC1.Text == DC2.Text) && (DC2.Text == DC3.Text) && (!DC1.Enabled) && (!lbl_D_Block.Visible))//END HORIZONTAL CHECKS
                || ((DA1.Text == DB1.Text) && (DB1.Text == DC1.Text) && (!DA1.Enabled) && (!lbl_D_Block.Visible))//VERTICAL CHECKS
                || ((DA2.Text == DB2.Text) && (DB2.Text == DC2.Text) && (!DA2.Enabled) && (!lbl_D_Block.Visible))//
                || ((DA3.Text == DB3.Text) && (DB3.Text == DC3.Text) && (!DA3.Enabled) && (!lbl_D_Block.Visible))//END VERTICAL CHECKS
                || ((DA1.Text == DB2.Text) && (DB2.Text == DC3.Text) && (!DA1.Enabled) && (!lbl_D_Block.Visible))//-DIAGONAL CHECKS-
                || ((DA3.Text == DB2.Text) && (DB2.Text == DC1.Text) && (!DA3.Enabled) && (!lbl_D_Block.Visible)))//-END DIAGONAL CHECKS-

                D_block_Winner = true;


            if (D_block_Winner)
            {
                String Dblock_Winner = "";
                if (turn)
                {
                    Dblock_Winner = "O";
                }
                else
                {
                    Dblock_Winner = "X";
                }
                lbl_D_Block.Text = Dblock_Winner;
                lbl_D_Block.Visible = true;
                draw++;

            }

            if ((D_Block_Draw == 9) && (!D_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                DA1.Text = "";
                DA2.Text = "";
                DA3.Text = "";
                DB1.Text = "";
                DB2.Text = "";
                DB3.Text = "";
                DC1.Text = "";
                DC2.Text = "";
                DC3.Text = "";
                DA1.Enabled = true;
                DA2.Enabled = true;
                DA3.Enabled = true;
                DB1.Enabled = true;
                DB2.Enabled = true;
                DB3.Enabled = true;
                DC1.Enabled = true;
                DC2.Enabled = true;
                DC3.Enabled = true;
                D_Block_Draw -= 9;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////E BLOCK
            bool E_block_Winner = false;
            //Block E Check
            if (((EA1.Text == EA2.Text) && (EA2.Text == EA3.Text) && (!EA1.Enabled) && (!lbl_E_Block.Visible)) //HORIZONTAL CHECKS
                || ((EB1.Text == EB2.Text) && (EB2.Text == EB3.Text) && (!EB1.Enabled) && (!lbl_E_Block.Visible))//
                || ((EC1.Text == EC2.Text) && (EC2.Text == EC3.Text) && (!EC1.Enabled) && (!lbl_E_Block.Visible))//END HORIZONTAL CHECKS
                || ((EA1.Text == EB1.Text) && (EB1.Text == EC1.Text) && (!EA1.Enabled) && (!lbl_E_Block.Visible))//VERTICAL CHECKS
                || ((EA2.Text == EB2.Text) && (EB2.Text == EC2.Text) && (!EA2.Enabled) && (!lbl_E_Block.Visible))//
                || ((EA3.Text == EB3.Text) && (EB3.Text == EC3.Text) && (!EA3.Enabled) && (!lbl_E_Block.Visible))//END VERTICAL CHECKS
                || ((EA1.Text == EB2.Text) && (EB2.Text == EC3.Text) && (!EA1.Enabled) && (!lbl_E_Block.Visible))//-DIAGONAL CHECKS-
                || ((EA3.Text == EB2.Text) && (EB2.Text == EC1.Text) && (!EA3.Enabled) && (!lbl_E_Block.Visible)))//-END DIAGONAL CHECKS-

                E_block_Winner = true;


            if ((E_block_Winner) && (!lbl_E_Block.Visible))
            {
                String Eblock_Winner = "";
                if (turn)
                {
                    Eblock_Winner = "O";
                }
                else
                {
                    Eblock_Winner = "X";
                }
                lbl_E_Block.Text = Eblock_Winner;
                lbl_E_Block.Visible = true;
                draw++;

            }

            if ((E_Block_Draw == 9) && (!E_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                EA1.Text = "";
                EA2.Text = "";
                EA3.Text = "";
                EB1.Text = "";
                EB2.Text = "";
                EB3.Text = "";
                EC1.Text = "";
                EC2.Text = "";
                EC3.Text = "";
                EA1.Enabled = true;
                EA2.Enabled = true;
                EA3.Enabled = true;
                EB1.Enabled = true;
                EB2.Enabled = true;
                EB3.Enabled = true;
                EC1.Enabled = true;
                EC2.Enabled = true;
                EC3.Enabled = true;
                E_Block_Draw -= 9;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////F BLOCK
            bool F_block_Winner = false;
            //Block F Check
            if (((FA1.Text == FA2.Text) && (FA2.Text == FA3.Text) && (!FA1.Enabled) && (!lbl_F_Block.Visible)) //HORIZONTAL CHECKS
                || ((FB1.Text == FB2.Text) && (FB2.Text == FB3.Text) && (!FB1.Enabled) && (!lbl_F_Block.Visible))//
                || ((FC1.Text == FC2.Text) && (FC2.Text == FC3.Text) && (!FC1.Enabled) && (!lbl_F_Block.Visible))//END HORIZONTAL CHECKS
                || ((FA1.Text == FB1.Text) && (FB1.Text == FC1.Text) && (!FA1.Enabled) && (!lbl_F_Block.Visible))//VERTICAL CHECKS
                || ((FA2.Text == FB2.Text) && (FB2.Text == FC2.Text) && (!FA2.Enabled) && (!lbl_F_Block.Visible))//
                || ((FA3.Text == FB3.Text) && (FB3.Text == FC3.Text) && (!FA3.Enabled) && (!lbl_F_Block.Visible))//END VERTICAL CHECKS
                || ((FA1.Text == FB2.Text) && (FB2.Text == FC3.Text) && (!FA1.Enabled) && (!lbl_F_Block.Visible))//-DIAGONAL CHECKS-
                || ((FA3.Text == FB2.Text) && (FB2.Text == FC1.Text) && (!FA3.Enabled) && (!lbl_F_Block.Visible)))//-END DIAGONAL CHECKS-

                F_block_Winner = true;


            if (F_block_Winner)
            {
                String Fblock_Winner = "";
                if (turn)
                {
                    Fblock_Winner = "O";
                }
                else
                {
                    Fblock_Winner = "X";
                }
                lbl_F_Block.Text = Fblock_Winner;
                lbl_F_Block.Visible = true;
                draw++;

            }

            if ((F_Block_Draw == 9) && (!F_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                FA1.Text = "";
                FA2.Text = "";
                FA3.Text = "";
                FB1.Text = "";
                FB2.Text = "";
                FB3.Text = "";
                FC1.Text = "";
                FC2.Text = "";
                FC3.Text = "";
                FA1.Enabled = true;
                FA2.Enabled = true;
                FA3.Enabled = true;
                FB1.Enabled = true;
                FB2.Enabled = true;
                FB3.Enabled = true;
                FC1.Enabled = true;
                FC2.Enabled = true;
                FC3.Enabled = true;
                F_Block_Draw -= 9;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////G BLOCK
            bool G_block_Winner = false;
            //Block G Check
            if (((GA1.Text == GA2.Text) && (GA2.Text == GA3.Text) && (!GA1.Enabled) && (!lbl_G_Block.Visible)) //HORIZONTAL CHECKS
                || ((GB1.Text == GB2.Text) && (GB2.Text == GB3.Text) && (!GB1.Enabled) && (!lbl_G_Block.Visible))//
                || ((GC1.Text == GC2.Text) && (GC2.Text == GC3.Text) && (!GC1.Enabled) && (!lbl_G_Block.Visible))//END HORIZONTAL CHECKS
                || ((GA1.Text == GB1.Text) && (GB1.Text == GC1.Text) && (!GA1.Enabled) && (!lbl_G_Block.Visible))//VERTICAL CHECKS
                || ((GA2.Text == GB2.Text) && (GB2.Text == GC2.Text) && (!GA2.Enabled) && (!lbl_G_Block.Visible))//
                || ((GA3.Text == GB3.Text) && (GB3.Text == GC3.Text) && (!GA3.Enabled) && (!lbl_G_Block.Visible))//END VERTICAL CHECKS
                || ((GA1.Text == GB2.Text) && (GB2.Text == GC3.Text) && (!GA1.Enabled) && (!lbl_G_Block.Visible))//-DIAGONAL CHECKS-
                || ((GA3.Text == GB2.Text) && (GB2.Text == GC1.Text) && (!GA3.Enabled) && (!lbl_G_Block.Visible)))//-END DIAGONAL CHECKS-

                G_block_Winner = true;


            if (G_block_Winner)
            {
                String Gblock_Winner = "";
                if (turn)
                {
                    Gblock_Winner = "O";
                }
                else
                {
                    Gblock_Winner = "X";
                }
                lbl_G_Block.Text = Gblock_Winner;
                lbl_G_Block.Visible = true;
                draw++;

            }

            if ((G_Block_Draw == 9) && (!G_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                GA1.Text = "";
                GA2.Text = "";
                GA3.Text = "";
                GB1.Text = "";
                GB2.Text = "";
                GB3.Text = "";
                GC1.Text = "";
                GC2.Text = "";
                GC3.Text = "";
                GA1.Enabled = true;
                GA2.Enabled = true;
                GA3.Enabled = true;
                GB1.Enabled = true;
                GB2.Enabled = true;
                GB3.Enabled = true;
                GC1.Enabled = true;
                GC2.Enabled = true;
                GC3.Enabled = true;
                G_Block_Draw -= 9;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////H BLOCK
            bool H_block_Winner = false;
            //Block H Check
            if (((HA1.Text == HA2.Text) && (HA2.Text == HA3.Text) && (!HA1.Enabled) && (!lbl_H_Block.Visible)) //HORIZONTAL CHECKS
                || ((HB1.Text == HB2.Text) && (HB2.Text == HB3.Text) && (!HB1.Enabled) && (!lbl_H_Block.Visible))//
                || ((HC1.Text == HC2.Text) && (HC2.Text == HC3.Text) && (!HC1.Enabled) && (!lbl_H_Block.Visible))//END HORIZONTAL CHECKS
                || ((HA1.Text == HB1.Text) && (HB1.Text == HC1.Text) && (!HA1.Enabled) && (!lbl_H_Block.Visible))//VERTICAL CHECKS
                || ((HA2.Text == HB2.Text) && (HB2.Text == HC2.Text) && (!HA2.Enabled) && (!lbl_H_Block.Visible))//
                || ((HA3.Text == HB3.Text) && (HB3.Text == HC3.Text) && (!HA3.Enabled) && (!lbl_H_Block.Visible))//END VERTICAL CHECKS
                || ((HA1.Text == HB2.Text) && (HB2.Text == HC3.Text) && (!HA1.Enabled) && (!lbl_H_Block.Visible))//-DIAGONAL CHECKS-
                || ((HA3.Text == HB2.Text) && (HB2.Text == HC1.Text) && (!HA3.Enabled) && (!lbl_H_Block.Visible)))//-END DIAGONAL CHECKS-

                H_block_Winner = true;


            if ((H_block_Winner) && (!lbl_H_Block.Visible))
            {
                String Hblock_Winner = "";
                if (turn)
                {
                    Hblock_Winner = "O";
                }
                else
                {
                    Hblock_Winner = "X";
                }
                lbl_H_Block.Text = Hblock_Winner;
                lbl_H_Block.Visible = true;
                draw++;

            }

            if ((H_Block_Draw == 9) && (!H_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                HA1.Text = "";
                HA2.Text = "";
                HA3.Text = "";
                HB1.Text = "";
                HB2.Text = "";
                HB3.Text = "";
                HC1.Text = "";
                HC2.Text = "";
                HC3.Text = "";
                HA1.Enabled = true;
                HA2.Enabled = true;
                HA3.Enabled = true;
                HB1.Enabled = true;
                HB2.Enabled = true;
                HB3.Enabled = true;
                HC1.Enabled = true;
                HC2.Enabled = true;
                HC3.Enabled = true;
                H_Block_Draw -= 9;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////I BLOCK
            bool I_block_Winner = false;
            //Block I Check
            if (((IA1.Text == IA2.Text) && (IA2.Text == IA3.Text) && (!IA1.Enabled) && (!lbl_I_Block.Visible)) //HORIZONTAL CHECKS
                || ((IB1.Text == IB2.Text) && (IB2.Text == IB3.Text) && (!IB1.Enabled) && (!lbl_I_Block.Visible))//
                || ((IC1.Text == IC2.Text) && (IC2.Text == IC3.Text) && (!IC1.Enabled) && (!lbl_I_Block.Visible))//END HORIZONTAL CHECKS
                || ((IA1.Text == IB1.Text) && (IB1.Text == IC1.Text) && (!IA1.Enabled) && (!lbl_I_Block.Visible))//VERTICAL CHECKS
                || ((IA2.Text == IB2.Text) && (IB2.Text == IC2.Text) && (!IA2.Enabled) && (!lbl_I_Block.Visible))//
                || ((IA3.Text == IB3.Text) && (IB3.Text == IC3.Text) && (!IA3.Enabled) && (!lbl_I_Block.Visible))//END VERTICAL CHECKS
                || ((IA1.Text == IB2.Text) && (IB2.Text == IC3.Text) && (!IA1.Enabled) && (!lbl_I_Block.Visible))//-DIAGONAL CHECKS-
                || ((IA3.Text == IB2.Text) && (IB2.Text == IC1.Text) && (!IA3.Enabled) && (!lbl_I_Block.Visible)))//-END DIAGONAL CHECKS-

                I_block_Winner = true;


            if (I_block_Winner)
            {
                String Iblock_Winner = "";
                if (turn)
                {
                    Iblock_Winner = "O";
                }
                else
                {
                    Iblock_Winner = "X";
                }
                lbl_I_Block.Text = Iblock_Winner;
                lbl_I_Block.Visible = true;
                draw++;

            }

            if ((I_Block_Draw == 9) && (!I_block_Winner)) //IF A FIGHT FOR A BLOCK IS A TIE, AND NOBODY IS DECALAIRED WINNER CLEAR IT.
            {
                IA1.Text = "";
                IA2.Text = "";
                IA3.Text = "";
                IB1.Text = "";
                IB2.Text = "";
                IB3.Text = "";
                IC1.Text = "";
                IC2.Text = "";
                IC3.Text = "";
                IA1.Enabled = true;
                IA2.Enabled = true;
                IA3.Enabled = true;
                IB1.Enabled = true;
                IB2.Enabled = true;
                IB3.Enabled = true;
                IC1.Enabled = true;
                IC2.Enabled = true;
                IC3.Enabled = true;
                I_Block_Draw -= 9;
            }
        }//END BLOCK WINNER CHECKS
/// <summary>
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
        private void checkForWinner()//CHECK FOR WINNER
        {
            bool there_is_a_winner = false;

            if (((lbl_A_Block.Text == lbl_B_Block.Text) && (lbl_B_Block.Text == lbl_C_Block.Text) && (lbl_A_Block.Visible)//HORIZONTAL BLOCK CHECKS
                || (lbl_D_Block.Text == lbl_E_Block.Text) && (lbl_E_Block.Text == lbl_F_Block.Text) && (lbl_D_Block.Visible)//
                || (lbl_G_Block.Text == lbl_H_Block.Text) && (lbl_H_Block.Text == lbl_I_Block.Text) && (lbl_G_Block.Visible)//END HORIZONTAL BLOCK CHECKS
                || (lbl_A_Block.Text == lbl_D_Block.Text) && (lbl_D_Block.Text == lbl_G_Block.Text) && (lbl_A_Block.Visible)//VERTICAL BLOCK CHECKS
                || (lbl_B_Block.Text == lbl_E_Block.Text) && (lbl_E_Block.Text == lbl_H_Block.Text) && (lbl_B_Block.Visible)//
                || (lbl_C_Block.Text == lbl_F_Block.Text) && (lbl_F_Block.Text == lbl_I_Block.Text) && (lbl_C_Block.Visible)//END VERTICAL BLOCK CHECKS
                || (lbl_A_Block.Text == lbl_E_Block.Text) && (lbl_E_Block.Text == lbl_I_Block.Text) && (lbl_A_Block.Visible)//-DIAGONAL BLOCK CHECKS-
                || (lbl_C_Block.Text == lbl_E_Block.Text) && (lbl_E_Block.Text == lbl_G_Block.Text) && (lbl_C_Block.Visible)))//-END DIAGONAL BLOCK CHECKS-

                there_is_a_winner = true;
            

            if (there_is_a_winner)
            {
                disableButtons();
                String winner = "";
                if (turn)
                {
                    winner = Player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = Player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!");
            }
            if ((draw == 9) && (!there_is_a_winner)) //Change to check buttons enabled
            {
                MessageBox.Show("Draw");
                draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
            }
        }//END CHECK FOR WINNER

        private void disableButtons() //When called, disables all buttons. Should only be called when a winner is declared.
        {

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
                catch { }
            }

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
            else
                Application.Exit();
        }


    }
}
