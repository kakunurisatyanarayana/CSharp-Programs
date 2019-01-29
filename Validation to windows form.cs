using System;
using System.Windows.Forms;
class Employee:Form
{
	public Label namelabel;
	public TextBox name;
	public Label salarylabel;
	public TextBox salary;
	public Button register;
	Employee(){
		this.SuspendLayout();
		//Name Label And TextBox
		namelabel=new Label();
		this.namelabel.Text="Name";
		name=new TextBox();
		namelabel.Location  = new System.Drawing.Point(1,20);
		name.Location  = new System.Drawing.Point(80,20);
		this.Controls.Add(namelabel);
		this.Controls.Add(name);
		//Salary Label And TextBox
		salarylabel=new Label();
		this.salarylabel.Text="Salary";
		salary=new TextBox();
		salarylabel.Location  = new System.Drawing.Point(1,40);
		salary.Location  = new System.Drawing.Point(80,40);
		this.Controls.Add(salarylabel);
		this.Controls.Add(salary);
		//Register Button
		register=new Button();
		register.Location  = new System.Drawing.Point(100,60);
		register.Text="Register";
		register.Click+=new System.EventHandler(save);
		this.Controls.Add(register);
		this.ResumeLayout(false);
	}
	public void save(Object Sender,EventArgs e){
		if(string.Empty==this.name.Text){
			 MessageBox.Show("Please enter name");
		}
		else if(string.Empty==this.salary.Text){
			 MessageBox.Show("Please enter salary");
		}	
	}
	public static void Main(){
		
		Application.Run(new Employee());
	
	}
	

}