using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSANBONG
{
    public class XuLy
    {
        public DataTable dtb2 = new DataTable();
        public DataTable dtb3 = new DataTable();
        public DataTable dtbBC = new DataTable();
        public List<string> thuoctinh = new List<string>();
        public List<string> PTH = new List<string>();
        public List<string> TN = new List<string>();
        public List<string> TG = new List<string>();
        public List<string> SK = new List<string>();
        public List<string> K = new List<string>();

        public bool ktraTonTai(List<string> baoDong, List<string> trai)
        {
            int dem = 0;
            foreach (string itemcon in trai)
            {
                foreach (string item in baoDong)
                {
                    if (itemcon == item)
                    {
                        dem++;
                    }
                }
            }
            if (dem == trai.Count)
            {
                return true;
            }
            return false;
        }

        public List<string> TimBaoDong(List<string> baoDong, List<string> trai, List<string> phai,List<string> PTH)
        {
            List<string> temp = new List<string>();
            int dem = 0;
            int flag = 0;
            if (baoDong.Count == 0)
            {
                baoDong = phai;
                baoDong.AddRange(trai);
            }
            if (baoDong.Count != 0)
            {
                do
                {
                    foreach (string pth in PTH)
                    {
                        trai = new List<string>();
                        phai = new List<string>();
                        string[] catchuoi = pth.Split('-');
                        string[] catchuoi1 = catchuoi[0].Split(',');
                        string[] catchuoi2 = catchuoi[1].Split(',');
                        trai.AddRange(catchuoi1);
                        phai.AddRange(catchuoi2);
                        if (ktraTonTai(baoDong, trai) == true)
                        {

                            foreach (string itemcon in phai)
                            {
                                dem = 0;
                                foreach (string item in baoDong)
                                {
                                    if (itemcon == item)
                                    {
                                        dem++;
                                    }
                                }
                                if (dem == 0)
                                {
                                    baoDong.Add(itemcon);
                                    dem = 0;
                                }
                            }

                        }
                    }
                    if (baoDong == temp)
                    {
                        flag = 1;
                    }
                    else
                    {
                        temp = new List<string>();
                        temp = baoDong;
                    }
                } while (flag != 1);
            }
            return baoDong;

        }

        public bool ThemTT(List<string> thuoctinh, string tt)
        {
            foreach (string item in thuoctinh)
            {
                if (item == tt)
                {
                    return false;
                }
            }
            thuoctinh.Add(tt);
            return true;
        }

        public bool ktra(string pth)
        {
            try
            {
                string[] catchuoi = pth.Split('-');
                string[] catchuoi1 = catchuoi[0].Split(',');
                string[] catchuoi2 = catchuoi[1].Split(',');
                int temp = 0;
                foreach (string item in thuoctinh)
                {

                    foreach (string chuoi in catchuoi1)
                    {
                        if (item == chuoi)
                        {
                            temp++;
                        }
                    }
                    foreach (string chuoi in catchuoi2)
                    {
                        if (item == chuoi)
                        {
                            temp++;
                        }
                    }
                }
                if (temp != catchuoi1.Length + catchuoi2.Length)
                {
                    return false;
                }
            }
            catch { return false; }
            return true;
        }

        public bool ThemPTH(List<string> PTH, string pth)
        {
            if (ktra(pth) == true)
            {
                foreach (string item in PTH)
                {
                    if (item == pth)
                    {
                        return false;
                    }
                }
                PTH.Add(pth);
            }
            return true;
        }

        int trai = 0;
        int phai = 0;

        public void TapNguon()
        {
            foreach (string item in thuoctinh)
            {
                foreach (string pth in PTH)
                {
                    try
                    {
                        string[] catchuoi = pth.Split('-');
                        string[] catchuoi1 = catchuoi[0].Split(',');
                        string[] catchuoi2 = catchuoi[1].Split(',');

                        foreach (string chuoi in catchuoi1)
                        {
                            if (item == chuoi)
                            {
                                trai++;
                            }
                        }
                        foreach (string chuoi in catchuoi2)
                        {
                            if (item == chuoi)
                            {
                                phai++;
                            }
                        }
                    }
                    catch { }
                }
                if (trai != 0 && phai == 0)
                {
                    TN.Add(item);
                    trai = 0;
                }
                else if (trai != 0 && phai != 0)
                {
                    TG.Add(item);
                    trai = 0;
                    phai = 0;
                }
                else
                {
                    trai = 0;
                    phai = 0;
                }

            }
        }

        public void SieuKhoa()
        {
            TN = new List<string>();
            TG = new List<string>();
            TapNguon();
            try
            {
                List<string> TNtemp = TN;
                List<string> TGtemp = TG;
                List<string> baoDong = new List<string>();
                List<string> trai = new List<string>();
                List<string> phai = new List<string>();
                int flag = -1;
                if (flag == -1)
                {
                    if (ktraPTH(TNtemp, PTH) != null)
                    {
                        List<string> temp = ktraPTH(TNtemp, PTH);
                        foreach (string pth in temp)
                        {
                            trai = new List<string>();
                            phai = new List<string>();
                            baoDong = new List<string>();
                            string[] catchuoi = pth.Split('-');
                            string[] catchuoi1 = catchuoi[0].Split(',');
                            string[] catchuoi2 = catchuoi[1].Split(',');
                            trai.AddRange(catchuoi1);
                            phai.AddRange(catchuoi2);
                            baoDong = TimBaoDong(baoDong, trai, phai,PTH);
                            if (baoDong.Count == thuoctinh.Count)
                            {
                                SK = new List<string>();
                                string s = "";
                                foreach (string item in TNtemp)
                                {
                                    if (s == "")
                                    {
                                        s = item;
                                    }
                                    else
                                    {
                                        s = s + "," + item;
                                    }
                                }
                                SK.Add(s);
                            }
                        }

                    }
                    flag = 1;
                }
                if (flag != 1)
                {

                    foreach (string tg in TGtemp)
                    {
                        trai = new List<string>();
                        phai = new List<string>();
                        baoDong = new List<string>();
                        TNtemp.Add(tg);
                        if (ktraPTH(TNtemp, PTH) != null)
                        {
                            List<string> temp = ktraPTH(TNtemp, PTH);
                            foreach (string pth in temp)
                            {
                                trai = new List<string>();
                                phai = new List<string>();
                                baoDong = new List<string>();
                                string[] catchuoi = pth.Split('-');
                                string[] catchuoi1 = catchuoi[0].Split(',');
                                string[] catchuoi2 = catchuoi[1].Split(',');
                                trai.AddRange(catchuoi1);
                                phai.AddRange(catchuoi2);
                                baoDong = TimBaoDong(baoDong, trai, phai,PTH);
                                if (baoDong.Count == thuoctinh.Count)
                                {
                                    string s = "";
                                    foreach (string item in TNtemp)
                                    {
                                        if (s == "")
                                        {
                                            s = item;
                                        }
                                        else
                                        {
                                            s = s + "," + item;
                                        }
                                    }
                                    SK.Add(s);
                                }
                            }

                        }
                    }
                }
            }
            catch
            {
            }
        }

        public void Khoa()
        {
            SieuKhoa();
            if (K.Count == 0)
            {
                K.Add(SK[0]);
            }
            try
            {
                foreach (string item in SK)
                {
                    foreach (string itemcon in K)
                    {
                        if (item.IndexOf(itemcon) == -1)
                        {
                            K.Add(item);
                        }
                    }
                }
            }
            catch
            {
            }

        }

        public List<string> ktraPTH(List<string> TNtemp, List<string> PTH)
        {
            List<string> pthcon = new List<string>();
            int dem = 0;
            foreach (string pth in PTH)
            {
                string[] catchuoi = pth.Split('-');
                string[] catchuoi1 = catchuoi[0].Split(',');
                string[] catchuoi2 = catchuoi[1].Split(',');

                foreach (string item in TNtemp)
                {
                    foreach (string itemcon in catchuoi1)
                    {
                        if (item == itemcon)
                        {
                            dem++;
                        }
                    }
                    if (dem == catchuoi1.Length)
                    {
                        pthcon.Add(pth);
                    }
                    else
                    {
                        dem = 0;
                    }
                }

            }
            return pthcon;
        }

        public bool ktraC2(List<string> key, string pth)
        {
            List<string> trai = new List<string>();
            List<string> phai = new List<string>();

            string[] catchuoi = pth.Split('-');
            string[] catchuoi1 = catchuoi[0].Split(',');
            string[] catchuoi2 = catchuoi[1].Split(',');
            trai.AddRange(catchuoi1);
            phai.AddRange(catchuoi2);
            for (int i = 0; i < key.Count; i++)
            {
                List<string> tempkey = new List<string>();
                tempkey.Add(key[i]);
                if (trai != tempkey)
                {
                    return false;
                }
            }

            return true;
        }

        public void Chuan2()
        {
            dtb2 = new DataTable();
            dtb2.Columns.Add("LDQH");
            dtb2.Columns.Add("TT");
            dtb2.Columns.Add("PTH");
            dtb2.Columns.Add("Khoa");
           
            List<string> key = K;
            List<string> pth = PTH;
            List<string> TT = new List<string>();
            for (int i = 0; i < pth.Count; i++)
            {
                string s = "";
                string s1 = "";
                if (ktraC2(key, pth[i]) == false)
                {
                    TT = new List<string>();
                    string[] catchuoi = pth[i].Split('-');
                    string[] catchuoi1 = catchuoi[0].Split(',');
                    string[] catchuoi2 = catchuoi[1].Split(',');
                    TT.AddRange(catchuoi1);
                    TT.AddRange(catchuoi2);
                    foreach (string item in TT)
                    {
                        if (s == "")
                        {
                            s = item;
                        }
                        else
                        {
                            s = s + "," + item;
                        }
                    }
                    foreach (string item in catchuoi1)
                    {
                        if (s1 == "")
                        {
                            s1 = item;
                        }
                        else
                        {
                            s1 = s1 + "," + item;
                        }
                    }
                    DataRow row = dtb2.NewRow();
                    row["LDQH"] = "QLSANBONG_Chuan2" + i;
                    row["TT"] = s;
                    row["PTH"] = pth[i];
                    row["Khoa"] = s1;
                    dtb2.Rows.Add(row);
                }
            }

        }

        public bool ktraC3(List<string> key,List<string> superkey, string pth)
        {
            List<string> trai = new List<string>();
            List<string> phai = new List<string>();

            string[] catchuoi = pth.Split('-');
            string[] catchuoi1 = catchuoi[0].Split(',');
            string[] catchuoi2 = catchuoi[1].Split(',');
            trai.AddRange(catchuoi1);
            phai.AddRange(catchuoi2);
            for (int i = 0; i < key.Count;i++ )
            {
                List<string> tempkey = new List<string>();
                List<string> tempsk = new List<string>();
                tempkey.Add(key[i]);
                foreach (string item in superkey)
                {
                    tempsk.Add(item);
                    if (trai != tempsk || phai == tempkey)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void Chuan3()
        {
            dtb3 = new DataTable();
            dtb3.Columns.Add("LDQH");
            dtb3.Columns.Add("TT");
            dtb3.Columns.Add("PTH");
            dtb3.Columns.Add("Khoa");
            List<string> key = new List<string>();
            foreach (DataRow row in dtb2.Rows)
            {
                List<string> tapnguon = new List<string>();
                List<string> trunggian = new List<string>();
                string[] temptt = row["TT"].ToString().Split(',');
                string[] temppth = row["PTH"].ToString().Split(';');
                string[] tempkey = row["Khoa"].ToString().Split(';');
                key.AddRange(tempkey);
                List<string> temppth1 = new List<string>();
                temppth1.AddRange(temppth);
                List<string> temptt1 = new List<string>();
                temptt1.AddRange(temptt);
                List<string> tempSK = new List<string>();
                foreach (string item in temptt)
                {
                    foreach (string pth in temppth)
                    {
                        try
                        {
                            string[] catchuoi = pth.Split('-');
                            string[] catchuoi1 = catchuoi[0].Split(',');
                            string[] catchuoi2 = catchuoi[1].Split(',');

                            foreach (string chuoi in catchuoi1)
                            {
                                if (item == chuoi)
                                {
                                    trai++;
                                }
                            }
                            foreach (string chuoi in catchuoi2)
                            {
                                if (item == chuoi)
                                {
                                    phai++;
                                }
                            }
                        }
                        catch { }
                    }
                    if (trai != 0 && phai == 0)
                    {
                        tapnguon.Add(item);
                        trai = 0;
                    }
                    else if (trai != 0 && phai != 0)
                    {
                        trunggian.Add(item);
                        trai = 0;
                        phai = 0;
                    }
                    else
                    {
                        trai = 0;
                        phai = 0;
                    }

                }
                try
                {
                    List<string> TNtemp = tapnguon;
                    List<string> TGtemp = trunggian;
                    List<string> baoDong = new List<string>();
                    List<string> trai = new List<string>();
                    List<string> phai = new List<string>();
                    int flag = -1;
                    if (flag == -1)
                    {
                        if (ktraPTH(TNtemp, temppth1) != null)
                        {
                            List<string> temp = ktraPTH(TNtemp, temppth1);
                            foreach (string pth in temp)
                            {
                                trai = new List<string>();
                                phai = new List<string>();
                                baoDong = new List<string>();
                                string[] catchuoi = pth.Split('-');
                                string[] catchuoi1 = catchuoi[0].Split(',');
                                string[] catchuoi2 = catchuoi[1].Split(',');
                                trai.AddRange(catchuoi1);
                                phai.AddRange(catchuoi2);
                                baoDong = TimBaoDong(baoDong, trai, phai,temppth1);
                                if (baoDong.Count == temptt1.Count)
                                {
                                    tempSK = new List<string>();
                                    string s = "";
                                    foreach (string item in TNtemp)
                                    {
                                        if (s == "")
                                        {
                                            s = item;
                                        }
                                        else
                                        {
                                            s = s + "," + item;
                                        }
                                    }
                                    tempSK.Add(s);
                                }
                            }

                        }
                        flag = 1;
                    }
                    if (flag != 1)
                    {

                        foreach (string tg in TGtemp)
                        {
                            trai = new List<string>();
                            phai = new List<string>();
                            baoDong = new List<string>();
                            TNtemp.Add(tg);
                            if (ktraPTH(TNtemp, temppth1) != null)
                            {
                                List<string> temp = ktraPTH(TNtemp, temppth1);
                                foreach (string pth in temp)
                                {
                                    trai = new List<string>();
                                    phai = new List<string>();
                                    baoDong = new List<string>();
                                    string[] catchuoi = pth.Split('-');
                                    string[] catchuoi1 = catchuoi[0].Split(',');
                                    string[] catchuoi2 = catchuoi[1].Split(',');
                                    trai.AddRange(catchuoi1);
                                    phai.AddRange(catchuoi2);
                                    baoDong = TimBaoDong(baoDong, trai, phai, temppth1);
                                    if (baoDong.Count == temptt1.Count)
                                    {
                                        string s = "";
                                        foreach (string item in TNtemp)
                                        {
                                            if (s == "")
                                            {
                                                s = item;
                                            }
                                            else
                                            {
                                                s = s + "," + item;
                                            }
                                        }
                                        tempSK.Add(s);
                                    }
                                }
                            }
                            
                        }
                        
                    }
                }
                catch
                {
                }
                List<string> key1 = key;
                List<string> pth1 = temppth1;
                List<string> TT = new List<string>();
                for (int i = 0; i < pth1.Count; i++)
                {
                    string s = "";
                    string s1 = "";
                    if (ktraC3(key1, tempSK, pth1[i]) == false)
                    {
                        TT = new List<string>();
                        string[] catchuoi = pth1[i].Split('-');
                        string[] catchuoi1 = catchuoi[0].Split(',');
                        string[] catchuoi2 = catchuoi[1].Split(',');
                        TT.AddRange(catchuoi1);
                        TT.AddRange(catchuoi2);
                        foreach (string item in TT)
                        {
                            if (s == "")
                            {
                                s = item;
                            }
                            else
                            {
                                s = s + "," + item;
                            }
                        }
                        foreach (string item in catchuoi1)
                        {
                            if (s1 == "")
                            {
                                s1 = item;
                            }
                            else
                            {
                                s1 = s1 + ";" + item;
                            }
                        }
                        DataRow row1 = dtb3.NewRow();
                        row1["LDQH"] = "QLSANBONG_Chuan3" + i;
                        row1["TT"] = s;
                        row1["PTH"] = pth1[i];
                        row1["Khoa"] = s1;
                        dtb3.Rows.Add(row1);
                    }
                }
            }
        }

        public bool ktraBC(List<string> key, List<string> superkey, string pth)
        {
            List<string> trai = new List<string>();
            List<string> phai = new List<string>();

            string[] catchuoi = pth.Split('-');
            string[] catchuoi1 = catchuoi[0].Split(',');
            string[] catchuoi2 = catchuoi[1].Split(',');
            trai.AddRange(catchuoi1);
            phai.AddRange(catchuoi2);
            for (int i = 0; i < key.Count; i++)
            {
                List<string> tempkey = new List<string>();
                List<string> tempsk = new List<string>();
                tempkey.Add(key[i]);
                foreach (string item in superkey)
                {
                    tempsk.Add(item);
                    if (trai != tempsk)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void ChuanBC()
        {
            dtbBC = new DataTable();
            dtbBC.Columns.Add("LDQH");
            dtbBC.Columns.Add("TT");
            dtbBC.Columns.Add("PTH");
            dtbBC.Columns.Add("Khoa");
            List<string> key = new List<string>();
            foreach (DataRow row in dtb3.Rows)
            {
                List<string> tapnguon = new List<string>();
                List<string> trunggian = new List<string>();
                string[] temptt = row["TT"].ToString().Split(',');
                string[] temppth = row["PTH"].ToString().Split(';');
                string[] tempkey = row["Khoa"].ToString().Split(';');
                key.AddRange(tempkey);
                List<string> temppth1 = new List<string>();
                temppth1.AddRange(temppth);
                List<string> temptt1 = new List<string>();
                temptt1.AddRange(temptt);
                List<string> tempSK = new List<string>();
                foreach (string item in temptt)
                {
                    foreach (string pth in temppth)
                    {
                        try
                        {
                            string[] catchuoi = pth.Split('-');
                            string[] catchuoi1 = catchuoi[0].Split(',');
                            string[] catchuoi2 = catchuoi[1].Split(',');

                            foreach (string chuoi in catchuoi1)
                            {
                                if (item == chuoi)
                                {
                                    trai++;
                                }
                            }
                            foreach (string chuoi in catchuoi2)
                            {
                                if (item == chuoi)
                                {
                                    phai++;
                                }
                            }
                        }
                        catch { }
                    }
                    if (trai != 0 && phai == 0)
                    {
                        tapnguon.Add(item);
                        trai = 0;
                    }
                    else if (trai != 0 && phai != 0)
                    {
                        trunggian.Add(item);
                        trai = 0;
                        phai = 0;
                    }
                    else
                    {
                        trai = 0;
                        phai = 0;
                    }

                }
                try
                {
                    List<string> TNtemp = tapnguon;
                    List<string> TGtemp = trunggian;
                    List<string> baoDong = new List<string>();
                    List<string> trai = new List<string>();
                    List<string> phai = new List<string>();
                    int flag = -1;
                    if (flag == -1)
                    {
                        if (ktraPTH(TNtemp, temppth1) != null)
                        {
                            List<string> temp = ktraPTH(TNtemp, temppth1);
                            foreach (string pth in temp)
                            {
                                trai = new List<string>();
                                phai = new List<string>();
                                baoDong = new List<string>();
                                string[] catchuoi = pth.Split('-');
                                string[] catchuoi1 = catchuoi[0].Split(',');
                                string[] catchuoi2 = catchuoi[1].Split(',');
                                trai.AddRange(catchuoi1);
                                phai.AddRange(catchuoi2);
                                baoDong = TimBaoDong(baoDong, trai, phai, temppth1);
                                if (baoDong.Count == temptt1.Count)
                                {
                                    tempSK = new List<string>();
                                    string s = "";
                                    foreach (string item in TNtemp)
                                    {
                                        if (s == "")
                                        {
                                            s = item;
                                        }
                                        else
                                        {
                                            s = s + "," + item;
                                        }
                                    }
                                    tempSK.Add(s);
                                }
                            }

                        }
                        flag = 1;
                    }
                    if (flag != 1)
                    {

                        foreach (string tg in TGtemp)
                        {
                            trai = new List<string>();
                            phai = new List<string>();
                            baoDong = new List<string>();
                            TNtemp.Add(tg);
                            if (ktraPTH(TNtemp, temppth1) != null)
                            {
                                List<string> temp = ktraPTH(TNtemp, temppth1);
                                foreach (string pth in temp)
                                {
                                    trai = new List<string>();
                                    phai = new List<string>();
                                    baoDong = new List<string>();
                                    string[] catchuoi = pth.Split('-');
                                    string[] catchuoi1 = catchuoi[0].Split(',');
                                    string[] catchuoi2 = catchuoi[1].Split(',');
                                    trai.AddRange(catchuoi1);
                                    phai.AddRange(catchuoi2);
                                    baoDong = TimBaoDong(baoDong, trai, phai, temppth1);
                                    if (baoDong.Count == temptt1.Count)
                                    {
                                        string s = "";
                                        foreach (string item in TNtemp)
                                        {
                                            if (s == "")
                                            {
                                                s = item;
                                            }
                                            else
                                            {
                                                s = s + "," + item;
                                            }
                                        }
                                        tempSK.Add(s);
                                    }
                                }
                            }

                        }

                    }
                }
                catch
                {
                }
                List<string> key1 = key;
                List<string> pth1 = temppth1;
                List<string> TT = new List<string>();
                for (int i = 0; i < pth1.Count; i++)
                {
                    string s = "";
                    string s1 = "";
                    if (ktraBC(key1, tempSK, pth1[i]) == false)
                    {
                        TT = new List<string>();
                        string[] catchuoi = pth1[i].Split('-');
                        string[] catchuoi1 = catchuoi[0].Split(',');
                        string[] catchuoi2 = catchuoi[1].Split(',');
                        TT.AddRange(catchuoi1);
                        TT.AddRange(catchuoi2);
                        foreach (string item in TT)
                        {
                            if (s == "")
                            {
                                s = item;
                            }
                            else
                            {
                                s = s + "," + item;
                            }
                        }
                        foreach (string item in catchuoi1)
                        {
                            if (s1 == "")
                            {
                                s1 = item;
                            }
                            else
                            {
                                s1 = s1 + ";" + item;
                            }
                        }
                        DataRow row1 = dtbBC.NewRow();
                        row1["LDQH"] = "QLSANBONG_ChuanBC" + i;
                        row1["TT"] = s;
                        row1["PTH"] = pth1[i];
                        row1["Khoa"] = s1;
                        dtbBC.Rows.Add(row1);
                    }
                }
            }
        }
    }
}
