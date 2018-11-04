<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="L_4_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Замовлення піци</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 255px;
            left: 33px;
        }
        .auto-style2 {
            position: absolute;
            top: 101px;
            left: 52%;
            width: 227px;
            height: 148px;
        }
        .auto-style3 {
            position: absolute;
            top: 100px;
            left: 30%;
            width: 229px;
            height: 152px;
        }
        .auto-style4 {
            height: 260px;
            margin-left: 15px;
            margin-bottom: 60px;
        }
        .auto-style5 {
            position: absolute;
            top: 100px;
            left: 4%;
            width: 266px;
            height: 144px;
        }
        .auto-style6 {
            position: absolute;
            top: 102px;
            left: 74%;
            width: 278px;
            height: 145px;
        }
        .auto-style7 {
            margin-left: 16px;
        }
        #Button {
            background: rgb(28, 184, 65);
            color: white;
            border-radius: 4px;
            text-shadow: 0 1px 1px rgba(0, 0, 0, 0.2);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">

            <asp:Panel ID="Panel1" runat="server" CssClass="auto-style5">
                <asp:Label runat="server">Виберіть сорт піци</asp:Label>
                <br />
                <asp:CheckBox ID="pizzaTexas" runat="server" Text="Техас" /><br />
                <asp:CheckBox ID="pizzaCheese" runat="server" Text="Чотири сири" /><br />
                <asp:CheckBox ID="pizzaKarbonara" runat="server" Text="Карбонара" /><br />
                <asp:CheckBox ID="pizzaBarbecue" runat="server" Text="Барбекю" />
            </asp:Panel>
            
            <asp:Panel ID="Panel2" runat="server" CssClass="auto-style3">
                <asp:Label runat="server">Кількість</asp:Label>
                <br />
                <asp:TextBox ID="pizzaTexasCount" runat="server">0</asp:TextBox>
                <asp:TextBox ID="pizzaCheeseCount" runat="server">0</asp:TextBox>
                <asp:TextBox ID="pizzaKarbonaraCount" runat="server">0</asp:TextBox>
                <asp:TextBox ID="pizzaBarbecueCount" runat="server">0</asp:TextBox>
            </asp:Panel>

            <asp:Panel ID="Panel3" runat="server" CssClass="auto-style2">
                <asp:Label runat="server">Ціна за одну</asp:Label>
                <br />
                <asp:Label ID="pizzaTexasPrice1" runat="server" Text="100" /><br />
                <asp:Label ID="pizzaCheesePrice1" runat="server" Text="150" /><br />
                <asp:Label ID="pizzaKarbonaraPrice1" runat="server" Text="125" /><br />
                <asp:Label ID="pizzaBarbecuePrice1" runat="server" Text="130" />
            </asp:Panel>
            
            <asp:Panel ID="Panel4" runat="server" CssClass="auto-style6">
                <asp:Label runat="server">Ціна</asp:Label>
                <br />
                <asp:Label ID="pizzaTexasPrice" runat="server" Text="0" /><br />
                <asp:Label ID="pizzaCheesePrice" runat="server" Text="0" /><br />
                <asp:Label ID="pizzaKarbonaraPrice" runat="server" Text="0" /><br />
                <asp:Label ID="pizzaBarbecuePrice" runat="server" Text="0" />
            </asp:Panel>
            <asp:Button ID="Button" style="margin-top: 2px;"  runat="server" Text="Розрахувати" OnClick="Button1_Click" CssClass="auto-style1" />
            <h2>Ваше замовлення</h2>

            </div>
       <div class="auto-style7">
            <hr />
       <asp:Label ID="Discount" runat="server" Text="" Font-Bold="True" ></asp:Label>
       <br/>
       <h4>Сума до сплати :</h4>
       <br/>
       <asp:Label ID="SUM" runat="server" Text="0 грн" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    </div>
    </form>

            </body>
</html>
