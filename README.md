# Talabalar Qabul Dasturi (Student Enrollment Console App)

![C#](https://img.shields.io/badge/language-C%23-blue.svg)

## Loyihaning maqsadi

Ushbu konsol dasturi orqali maksimal 12 talaba ro‘yxatdan o‘tishi mumkin. Dasturga kirish uchun parol (default: `1234`) talab qilinadi, 3 ta xato urinishdan keyin dastur yopiladi. Dastur orqali talabalar ismi va familiyasi kiritilib, ularning soni va qabul statistikasi ko‘rsatiladi.

---

## Asosiy funksiyalar

- Parol bilan tizimga kirish (max 3 urinish)
- Talabalarni ro‘yxatdan o‘tkazish (ism va familiya bilan)
- Ro‘yxatdan o‘tgan talabalar sonini ko‘rsatish
- Qabul statistikasi (jami qabul qilinganlar, maksimal sig‘im, bo‘sh joylar)
- Maksimal 12 talaba qabul qilinadi

---

## Dastur ishlashi

1. Dastur ishga tushganda, foydalanuvchidan parol so‘raladi.
2. Parol noto‘g‘ri bo‘lsa, 3 urinishgacha imkoniyat beriladi.
3. Parol to‘g‘ri kiritilsa, menyu paydo bo‘ladi:
    - 1: Talaba ro‘yxatdan o‘tadi (ism va familiya)
    - 2: Ro‘yxatdan o‘tganlar sonini ko‘rish
    - 3: Qabul statistikasi
    - 0: Dasturdan chiqish

---

## O'rnatish va ishga tushirish

1. Visual Studio yoki .NET CLI yordamida loyiha faylini oching.
2. `Program.cs` faylini ishga tushiring.
3. Konsolda ko‘rsatilgan ko‘rsatmalarga amal qiling.

---


## Kod namunasi

```csharp
// Parol tekshirish va 3 urinish imkoniyati
int urinishlar = 0;
bool access = false;
do {
    Console.Write("Parolngizni kiriting: ");
    string password = Console.ReadLine();
    if (password == "1234") {
        access = true;
        break;
    }
    urinishlar++;
    Console.WriteLine($"Parol noto‘g‘ri! Qolgan urinishlar: {3 - urinishlar}");
} while (urinishlar < 3);
if (!access) {
    Console.WriteLine("Urinishlar soni tugadi. Dastur yopildi!");
    return;
}
```
---

## GIF

---

## Mualliflar

Asrorbek002 – Loyihaning dasturchisi va muallifi

ali-dev02 – Loyihaning hamkor dasturchisi

---
