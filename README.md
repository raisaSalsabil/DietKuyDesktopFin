# DietKuyDesktopFin
DietKuy adalah aplikasi untuk melakukan pengelolaan dan pemesanan menu diet dengan rekomendasi menu berdasarkan BMI (Body Mass Index) pengguna. Aplikasi ini menyediakan kalkulator BMI yang kemudian dapat diteruskan dengan pemesanan menu. Setelah memilih menu, pengguna dapat memilih alamat pengiriman. Lalu, aplikasi dapat meng-generate QR Code yang berisi informasi pemesanan. Selain itu, dari sisi administrator terdapat akses untuk menambahkan, mengedit, dan menghapus menu diet yang tersedia.

<br>
USERNAME DAN PASSWORD
<br>

Log in sebagai user: <br>
Username: bebas, misal: saskiamirna <br>
Password: bebas, misal: saskiamirna100 <br><br>

Log in sebagai administrator: <br>
Username: Admin <br>
Password: Admin

<br>
CARA PEMAKAIAN  <br>

Jika dengan Installer.rar :  Ektsrak folder, klik Setup dan pilih Install <br>
Jika dengan .exe :  masuk ke direktori DietKuyDesktop5 > bin > Debug > DietKuyDesktop5.exe <br>

Jika dengan Visual Studio: <br>
1.	Klik solution project .sln dan run
2.	Log in sebagai User atau Admin dengan password di atas
3.	Anda sudah sampai di Home, silakan pilih page yang ingin dibuka

<br>
Page yang tersedia:

a.	Sebagai Administrator
1)	Page Manage Day Menu
-	Isi seluruh textbox dengan rincian menu siang, contoh: 
    - ID: 1456 (ID harus integer unik)
    - Name: Honey Toast
    - Quantity: 15
    - Price: 15000
    - Category: Underweight -Food 
-	Klik Add untuk menambahkan menu baru, Edit untuk mengubah menu yang sudah ada, atau Delete untuk menghapus data dari tabel
-	Kembali ke Home dengan klik button Home

2)	Page Manage Night Menu
- Isi seluruh textbox dengan rincian menu malam, contoh: <br>
    - Sama seperti day menu, dengan tambahan:
    - Size: Normal
    - Extra: None

-	Klik Add untuk menambahkan menu baru, Edit untuk mengubah menu yang sudah ada, atau Delete untuk menghapus data dari tabel
-	Kembali ke Home dengan klik button Home

b.	Sebagai User (jika login sebagai user)
1)	Page Add Address
-	Isi seluruh textbox, contoh:
	  - ID: 12347 (harus angka unik)
    - Name: Saskia Mirna
    - Phone: 081326545487
    - Address: Jalan Tanjakan Biru No.46, Bukit Bersama
    - Desc: Rumah warna kuning

-	Klik Add untuk menambahkan alamat baru, Edit untuk mengubah alamat yang sudah ada, atau Delete untuk menghapus data dari tabel.
-	Kembali ke Home dengan klik button Home
2)	Page BMI Calculator
-	Isi berat badan dalam kg (misal: 56) dan tinggi badan dalam meter (misal: 1.6)
-	Klik “Check BMI”
-	Nilai BMI dan kategorinya akan ditampilkan
-	Klik “Check Menu” untuk melihat menu diet yang tersedia. 
-	Klik menu yang dipilih pada tabel
-	Anda dapat menyesuaikan pilihan menu sesuai dengan kategori anda dengan memilih keterangan kategori yang sama pada tabel
-	Klik salah satu alamat pada tabel
-	Klik “Generate QR Code” untuk menampilkan QR Code
-	Klik “Order Now!” untuk melakukan pemesanan


