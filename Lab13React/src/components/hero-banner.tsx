import React from "react";

export const HeroBanner: React.FC = () => {
  return (
    <div className="hero-banner hero-banner--pink-yellow">
      <h1 className="hero-banner__headline">Вітаю, це виконання 13 лаб. роб.</h1>
      <p className="hero-banner__description">
        Дана сторінка надає доступ до виконання 1-3 лаб. робіт.
        <br />
        <strong>Вхід до аккаунту реалізовано за допомогою Auth0</strong>.
      </p>
    </div>
  );
};
