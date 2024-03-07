namespace WFAAsyncSync_1
{
    public partial class Form1 : Form
    {
        //Bir metodun asenkron calısabilmesini istiyorsanız o metot geriye deger döndürse de döndürmese de önce Task tipi ile yaratılmalıdır...Task tipi  yaratıldıktan sonra metot eger geriye deger döndürmeyecekse Task'e baska bir sey yazılmaz...Eger geriye deger döndürecekse o deger tipi Task'e generic olarak verilir


        Task SelamlaAsync()
        {
            return Task.Run(() =>
            {

                Thread.Sleep(10000);
                MessageBox.Show("Async olarak cagrıldıgım icin görevim kimseyi engellemedi");

            });
        }


        public Form1()
        {
            InitializeComponent();
        }

        public int KareAl(int sayi)
        {
            Thread.Sleep(10000);
            return sayi * sayi;
        }

        //await keyword'u kullanılacak ise ilgili metodun cagrıldıgı alanın async keyword'une sahip olması gerekir...
        private async void btnSim_Click(object sender, EventArgs e)
        {
            await SelamlaAsync();
            MessageBox.Show("Gorev bitti");
        }

        private void btnSelam_Click(object sender, EventArgs e)
        {
            Selamla();
        }


        public void Selamla()
        {
            Thread.Sleep(10000);
            MessageBox.Show("Hello World");
        }
    }
}
