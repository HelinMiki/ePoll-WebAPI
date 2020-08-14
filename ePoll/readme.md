# ePoll API

## Ohjeet
Sovellus käyttää tietokantaa tiedon talletukseen. Jos käynnistät sovelluksen ePollAPI/bin/Debug-kansiosta, niin käytössäsi täytyy olla SQL Server Management Studio,
jotta saat yhteyden lokaaliin tietokantaan, johon tietokantasi rakennetaan (ePollDB). Lisätietoja tietokannan rakentamisesta tekstitiedostossa ePollAPI/A guide on how to build your database.txt.

Jos käynnistät kootun sovelluksen Debug kansiosta ja testaat sovelluksen API:a Postmanilla tai muulla vastaavalla sovelluksella, niin 
varmista, että kyseisen ohjelmiston SSL certificate verification -asetus on kytketty pois käytöstä. (esim. Postman: File -> Settings -> General -> SSL certificate verification).
Sovellus ei muutoin saa yhteyttä. Jos testaat sovellusta Virtual Studiossa (2019), niin asetusta ei tarvitse ottaa pois käytöstä.

## Koottu sovellus kuuntelee osoitteita:
	- https://localhost:5001
	- http://localhost:5000

## Eroavaisuuksia harjoitustyöstä / Bugeja, joita haluaisin korjata:
Tämän harjoitustyön GET: /polls listaa kyselyt suoraan tauluun.
JSON rakenne: [ { data }, { data2 }, { data3 },... ] 

Kun uusi kysely lisätään, palautuksessa ei nähdä uuden kyselyn oikeaa Id-tunnusta, vaan uuden kyselyn id näyttää arvon 0.
Jos tarkistat juuri lisätyn kyselyn (GET /polls), niin kysely on saanut Id-arvon.
Kyselyn Id saa arvonsa SQL:n Identitystä. Ongelma saataisiin ehkä ratkaistua lisäämällä Polls-tauluun Id:n lisäksi kyselyjen määrään liittyvä sarake, esim. PollNum tai PollNo,
joka saa arvonsa samalla tavalla kuin kyselyn vaihtoehdot.
Todennäköisesti ongelma Automapperin kanssa.

## Harjoitustyöhön on käytetty seuraavia NuGet-paketteja:
- Automapper.Extensions.Microsoft.DependencyInjection
- Microsoft.AspNetCore.Cors
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Relational
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools