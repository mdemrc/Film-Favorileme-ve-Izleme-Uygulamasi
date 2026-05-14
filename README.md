# Film Favourite & Playback Helper (`Film-Favorileme-ve-Izleme-Uygulamasi`)

[![SQL Server](https://img.shields.io/badge/SQL-SQL%20Server-CC2927?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)

## English

### Overview

**Film Arşivi** lets you save **titles + hyperlink fields** \(\streaming platform, trailers, trivia pages\) inside SQL catalogue **`FilmArsivi`** and revisit them quickly through **WinForms + DataGridView** navigation. Selecting a row triggers the **`WebBrowser` host control** \(\legacy Chromium-free shell\) to automate navigation—fine for curricula teaching COM-era Win32 hosting, acknowledging modern apps prefer **WebView2**.

### Responsibility boundaries

Treat stored URLs responsibly: only bookmark legal sources, obey site terms-of-use, rotate user agents sparingly \(\not required here\).

---

## Türkçe

### Genel bakış

**Film Favorileme ve İzleme** projesi kullanıcıya film adını ve bağlantısını MSSQL \(\`FilmArsivi\`\) verisine yazarak **DataGridView** üzerinden yönetme imkanı tanır; satır seçilince **`WebBrowser` bileşeni** ilgili linki masaüstü içinde açar \(\`İnternet Explorer` motoru kullanıcı deneyimi sınırlamalarına sahiptir; modern seçenek olarak **WebView2** araştırılmalıdır\).

### Güvenilir kullanım

Yalnızca yasal içerik linklerinin kaydedildiğinden ve telif gerekliliklerinin ihlal edilmediğinden emin olun.
