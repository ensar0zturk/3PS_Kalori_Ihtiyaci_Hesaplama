<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="kalorihtiyaci.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="social">
        <a href="index.html"><font>3PS |<span>Threes Power Studios</span></font></a>
        
    </div>
    <div id="container">
        <table>
            <tr>
                <td>
                    <asp:DropDownList ID="drp_cinsiyet" runat="server" Height="60px" Width="200px">
                        <asp:ListItem Text="-----CİNSİYETİNİZİ-SEÇİNİZ-----" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Erkek" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Kadın" Value="1"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_kilo" runat="server" placeholder="Kilonuz (örn. 76kg)" Height="60px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_yas" runat="server" placeholder="Yaşınız (örn. 18)" Height="60px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_boy" runat="server" placeholder="Boyunuz (örn 180cm)" Height="60px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="drp_aktivite" runat="server" Height="60px" Width="200px">
                        <asp:ListItem Text="-----AKTİVİTE-SEÇİNİZ-----" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Sedanter(Hareketsiz/hiç egzersiz yapmayan)" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Az Hareketli(Haftada 1-3 gün hafif egzersiz)" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Orta derecede aktif (haftada 3-5 gün orta düzeyde egzersiz)" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Çok aktif (haftada 6-7 gün yoğun egzersiz)" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Aşırı aktif (çok yoğun egzersiz veya fiziksel iş)" Value="4"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_hesapla" runat="server" Text="HESAPLA" Height="60px" Width="200px" OnClick="btn_hesapla_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_sonuc" runat="server" ></asp:TextBox>
                </td>
            </tr>
        </table>




        <footer><center>Tüm hakları saklıdır. &copy; | 2024</center></footer>
    </div>
    </form>
</body>
</html>
