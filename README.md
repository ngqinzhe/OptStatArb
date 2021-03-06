[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/othneildrew/Best-README-Template">
    <img src="https://github.com/ngqinzhe/OptStatArb/blob/master/OptStatArbApp/wwwroot/images/logo.gif" width="150" height="150">
  </a>

  <h2 align="center">OPTSTATARB</h2>

  <p align="center">
    Option Statistical Arbitrage Screener
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

According to option theory, there are possible arbitrage opportunities available in the market, and I wanted to be able to visually see these statistical approaches and comparisons take place live.

Objectives for this project:
* Provide users the ability to fetch option data for every ticker available in the market
* Show users that there are statistical arbitrage opportunities available in the market

<img src="https://github.com/ngqinzhe/OptStatArb/blob/master/OptStatArbApp/wwwroot/images/example2.png">

I calculated and ensured the difference between the statistical pricing and option market price is more than 10% of the option market price to determine if there is a possiblity of arbitrage. This gap is to factor out possbilities in accuracy of calculations and commisions from the purchase of options.

### Built With

* C#
* ASP.NET 
* Blazor

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Othniel Drew](https://github.com/othneildrew) for the amazing README template
* [Yahoo Finance API](https://rapidapi.com/apidojo/api/yahoo-finance1)



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/ngqinzhe/OptStatArb.svg?style=for-the-badge
[contributors-url]: https://github.com/ngqinzhe/OptStatArb/contributors
[forks-shield]: https://img.shields.io/github/forks/ngqinzhe/OptStatArb.svg?style=for-the-badge
[forks-url]: https://github.com/ngqinzhe/OptStatArb/network/members
[stars-shield]: https://img.shields.io/github/stars/ngqinzhe/OptStatArb.svg?style=for-the-badge
[stars-url]: https://github.com/ngqinzhe/OptStatArb/stargazers
[issues-shield]: https://img.shields.io/github/issues/ngqinzhe/OptStatArb.svg?style=for-the-badge
[issues-url]: https://github.com/ngqinzhe/OptStatArb/issues
