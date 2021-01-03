using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

class myLabel : System.Windows.Forms.Label
{
    public int RotateAngle { get; set; }  // to rotate your text
    public string NewText { get; set; }   // to draw text
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        Brush b = new SolidBrush(this.ForeColor);
        e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
        e.Graphics.RotateTransform(this.RotateAngle);
        e.Graphics.DrawString(this.NewText, this.Font, b, 0f, 0f);
        base.OnPaint(e);
    }
}

//You have to set below properties 
// 1. mylbl.Text = "";             //which can be changed by NewText property
// 2. mylbl.AutoSize = false;      // adjust according to your text
// 3. mylbl.NewText = "Hello";     // whatever you want to display
// 4. mylbl.ForeColor = Color.Red;  // color to display
// 5. mylbl.RotateAngle = -90;     //angle to rotate
