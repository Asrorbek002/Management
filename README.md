# 🎓 Talabalar Qabul Dasturi

![Gif](https://github.com/user-attachments/assets/0bedcd35-7b75-4548-852d-90fe2ed17a94)


Bu dastur C# tilida yozilgan va talabalarning ro‘yxatdan o‘tishini boshqarish tizimini amalga oshiradi.  

Dastur quyidagi funksiyalarni bajaradi:

- 🔒 Parol bilan tizimga kirish (3 urinish imkoniyati)  
- 👤 Yangi talaba qo‘shish (ism, familiya va ID avtomatik beriladi)  
- 📋 Talabalar ro‘yxatini ko‘rsatish  
- 📊 Qabul statistikasi (maksimal 12 ta talaba)  

---

## 📌 Xususiyatlar

| Funksiya || Tavsif |
| Tizimga kirish | Parol tekshiriladi, 3 urinish imkoniyati mavjud |
| Yangi talaba qo‘shish | Ism va familiya kiritiladi, ID tasodifiy generatsiya qilinadi |
| Talabalar ro‘yxati | Hozirgi qabul qilingan talabalar ko‘rsatiladi |
| Qabul statistikasi | Qabul qilinganlar soni va bo‘sh joylar ko‘rsatiladi |

---

## ⚡ Ishlatish

1. Dastur ishlashi uchun Visual Studio yoki boshqa C# IDE oching.
2. `Program.cs` faylini ishga tushiring.
3. Tizimga kirish uchun parolni kiriting: `1234`  
4. Menyudan kerakli amallarni tanlang:

1 - Yangi talaba qo‘shish
2 - Talabalar ro‘yxati
3 - Qabul statistikasi
0 - Chiqish


5. Dastur maksimal 12 ta talabani qabul qiladi.

---

## 🛠 Texnologiyalar

- .NET 9 
- Konsol dasturi (Console Application)

---


## 🔖 Bonus

Dastur foydalanuvchi tajribasini oshirish uchun quyidagi belgilar bilan ishlaydi:

- ✅ Muvaffaqiyatli ro‘yxatdan o‘tgan talaba  
- ❌ Noto‘g‘ri parol  
- ⛔ Maksimal urinishlar yoki qabul chegarasi  
- 📋 Talabalar ro‘yxati  
- 📊 Qabul statistikasi  

---

## 📂 Kod namunasi

```csharp
using Management.Application.Services;

internal class Program
{
    static StudentService studentService = new StudentService();
    const int urunishlar = 3;
    const int maxsigim = 12;

    static void Main(string[] args)
    {
        // Kodning to‘liq ishlash logikasi shu yerda
    }
}
Ushbu dastur talabalarning qabul jarayonini boshqarish uchun ishlab chiqilgan va
maksimal 12 ta talabani ro‘yxatdan o‘tkazadi.
```
---
## 👨‍💻 Mualliflar

**Asrorbek** 
- GitHub:(https://github.com/Asrorbek002)  
- Email: asrorbekabdurashidov5@gmail.com
##
   **Ali**
- GitHub: (https://github.com/ali-dev02)
- Email: alivaliyev20022@gmail.com

---


