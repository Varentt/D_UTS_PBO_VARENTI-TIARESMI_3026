using System;

class rekening
{
    private string NoRek;
    private string NamaPemilik;
    private double SaldoRekening;

    public string NoRek
    {
        get { return NoRek; }
        set { NoRek = value; }

    }

    public string NamaPemilik
    {
        get { return NamaPemilik;}
        set { NamaPemilik = value; }

    }

    public double SaldoRekening
    {
        get { return SaldoRekening; }
        set { SaldoRekening = value; }
    }

    public rekening(string NoRek, string NamaPemilik, double SaldoRekening)
    {
        this.NoRek = NoRek;
        this.NamaPemilik = NamaPemilik;
        this.SaldoRekening = SaldoRekening;
    }

    public void PenarikanDana(double jumlah)
    {
        if (jumlah <= SaldoRekening)
        {
            SaldoRekening -= jumlah;
            Console.WriteLine($"Penarikan Dana berhasil. Sisa saldo anda {Saldorekening}");

        }
        else
        {
            Console.WriteLine("saldo anda tidak mencukupi")
        }

    }

    public void SetorTunai(double jumlah)
    {
        SaldoRekening += jumlah;
        Console.WriteLine($"setor tunai berhasil. Sisa saldo anda {SaldoRekening}")
    }

    public void Transfer(RekeningTujuan, double jumlah)
    {
        if (jumlah <= SaldoRekening)
        {
            SaldoRekening -= jumlah;
            RekeningTujuan.SaldoRekening += jumlah;
            Console.WriteLine($"transfer telah berhasil ke {RekeningTujuan}");
        }

        else
        {
            Console.WriteLine("saldo anda tidak mencukupi")
        }

    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"nomor rekening: {NoRek}")
        Console.WriteLine($"nama pemilik: {NamaPemilik}")
        Console.WriteLine{($"saldo rekenig: {SaldoRekening")}
    }
}

class progam
    {
        static void main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Tarik Tunai \n2. Setor Tunai\n3. Transfer antar rekening");
                Console.WriteLine($"Pilih menu: ");
                string pilihan = Console.ReadLine();
            }
        }

    }

