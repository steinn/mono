//
// Authors:
//   Rafael Mizrahi   <rafim@mainsoft.com>
//   Erez Lotan       <erezl@mainsoft.com>
//   Vladimir Krasnov <vladimirk@mainsoft.com>
//
//
// Copyright (c) 2002-2005 Mainsoft Corporation.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GHTTests.System_Web_dll.System_Web_UI_WebControls
{public class BaseDataList_GridLines
        : GHTDataListBase
 {
	 #region Web Form Designer generated code
	 override protected void OnInit(EventArgs e) {
		 //
		 // CODEGEN: This call is required by the ASP.NET Web Form Designer.
		 //
		 InitializeComponent();
		 base.OnInit(e);
	 }
		
	 /// <summary>
	 /// Required method for Designer support - do not modify
	 /// the contents of this method with the code editor.
	 /// </summary>
	 private void InitializeComponent() {    
		 this.Load += new System.EventHandler(this.Page_Load);
	 }
	 #endregion

	 private delegate void BuildDataListControl(BaseDataList ctl);


        private void Page_Load(object sender, System.EventArgs e) 
		{
            HtmlForm frm  = (HtmlForm)FindControl("Form1");
            GHTTestBegin(frm);
			this.Test(typeof(DataGrid), new BaseDataList_GridLines.BuildDataListControl(this.GHTBuildUnboundSampleDataGrid));
			this.Test(typeof(DataList), new BaseDataList_GridLines.BuildDataListControl(this.GHTBuildUnboundSampleDataList));

            GHTTestEnd();

        }
	 private void Test(Type CtlType, BaseDataList_GridLines.BuildDataListControl CtlBuilder)
	 {
		 BaseDataList list1;
		 try
		 {
			 this.GHTSubTestBegin("BaseDataList_" + CtlType.Name + "_GridLines1");
			 list1 = (BaseDataList) this.GHTElementClone(CtlType);
			 base.GHTActiveSubTest.Controls.Add(list1);
			 CtlBuilder(list1);
			 list1.GridLines = GridLines.Both;
			 list1.DataSource = GHTDataListBase.GHTGetSampleDataSource();
			 list1.DataBind();
			 this.GHTSubTestExpectedExceptionNotCaught("argumentOutOfRange");
		 }
		 catch (Exception exception9)
		 {
			 this.GHTSubTestUnexpectedExceptionCaught(exception9);
		 }
		 this.GHTSubTestEnd();
		 try
		 {
			 this.GHTSubTestBegin("BaseDataList_" + CtlType.Name + "_GridLines2");
			 list1 = (BaseDataList) this.GHTElementClone(CtlType);
			 base.GHTActiveSubTest.Controls.Add(list1);
			 CtlBuilder(list1);
			 list1.GridLines = GridLines.Horizontal;
			 list1.DataSource = GHTDataListBase.GHTGetSampleDataSource();
			 list1.DataBind();
		 }
		 catch (Exception exception10)
		 {
			 this.GHTSubTestUnexpectedExceptionCaught(exception10);
		 }
		 this.GHTSubTestEnd();
		 try
		 {
			 this.GHTSubTestBegin("BaseDataList_" + CtlType.Name + "_GridLines3");
			 list1 = (BaseDataList) this.GHTElementClone(CtlType);
			 base.GHTActiveSubTest.Controls.Add(list1);
			 CtlBuilder(list1);
			 list1.GridLines = GridLines.Vertical;
			 list1.DataSource = GHTDataListBase.GHTGetSampleDataSource();
			 list1.DataBind();
		 }
		 catch (Exception exception11)
		 {
			 this.GHTSubTestUnexpectedExceptionCaught(exception11);
		 }
		 this.GHTSubTestEnd();
		 try
		 {
			 this.GHTSubTestBegin("BaseDataList_" + CtlType.Name + "_GridLines4");
			 list1 = (BaseDataList) this.GHTElementClone(CtlType);
			 base.GHTActiveSubTest.Controls.Add(list1);
			 CtlBuilder(list1);
			 list1.GridLines = GridLines.None;
			 list1.DataSource = GHTDataListBase.GHTGetSampleDataSource();
			 list1.DataBind();
		 }
		 catch (Exception exception12)
		 {
			 this.GHTSubTestUnexpectedExceptionCaught(exception12);
		 }
		 this.GHTSubTestEnd();
		 try
		 {
			 this.GHTSubTestBegin("BaseDataList_" + CtlType.Name + "_GridLines5");
			 list1 = (BaseDataList) this.GHTElementClone(CtlType);
			 base.GHTActiveSubTest.Controls.Add(list1);
			 CtlBuilder(list1);
			 list1.GridLines = ~GridLines.None;
			 list1.DataSource = GHTDataListBase.GHTGetSampleDataSource();
			 list1.DataBind();
		 }
		 catch (ArgumentOutOfRangeException exception13)
		 {
			 this.GHTSubTestExpectedExceptionCaught(exception13);
		 }
		 catch (Exception exception14)
		 {
			 this.GHTSubTestUnexpectedExceptionCaught(exception14);
		 }
		 this.GHTSubTestEnd();
		 try
		 {
			 this.GHTSubTestBegin("BaseDataList_" + CtlType.Name + "_GridLines5");
			 list1 = (BaseDataList) this.GHTElementClone(CtlType);
			 base.GHTActiveSubTest.Controls.Add(list1);
			 CtlBuilder(list1);
			 list1.GridLines = (GridLines) 4;
			 list1.DataSource = GHTDataListBase.GHTGetSampleDataSource();
			 list1.DataBind();
		 }
		 catch (ArgumentOutOfRangeException exception15)
		 {
			 this.GHTSubTestExpectedExceptionCaught(exception15);
		 }
		 catch (Exception exception16)
		 {
			 this.GHTSubTestUnexpectedExceptionCaught(exception16);
		 }
		 this.GHTSubTestEnd();
	 }
 

    }
}
