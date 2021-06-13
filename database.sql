-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 22 2021 г., 17:39
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `database`
--

-- --------------------------------------------------------

--
-- Структура таблицы `пользователи`
--

CREATE TABLE `пользователи` (
  `id_пользователя` int(11) NOT NULL,
  `login` varchar(45) DEFAULT NULL,
  `passord` varchar(45) DEFAULT NULL,
  `админ` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `пользователи`
--

INSERT INTO `пользователи` (`id_пользователя`, `login`, `passord`, `админ`) VALUES
(0, 'Admin', 'Admin', 1),
(1, 'Root', 'Root', 1),
(2, 'MarinaStepanova695', 'apJ1wED3YamR', 0),
(3, 'NikandrTretyakov203', 'EzB6eAe0FZW0', 0),
(4, 'ApollinariyaDruzhinina746', 'BPEqYnnoun42', 0),
(5, 'KirillUshakov392', 'dbaTwRuRKWb4', 0),
(6, 'KazimiraFilippova534', 'imQekmlYQZEB', 0),
(7, 'IyaBrazhnikova490', 's4wEz3MiIRkh', 0),
(8, 'AlenaNovikova252', ' zpwTHpmiSXGA', 1),
(9, 'test', 'test', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `актёры`
--

CREATE TABLE `актёры` (
  `id_актёра` tinyint(4) NOT NULL,
  `номер` tinyint(4) DEFAULT NULL,
  `фио` char(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ранг` char(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `опыт` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `актёры`
--

INSERT INTO `актёры` (`id_актёра`, `номер`, `фио`, `ранг`, `опыт`) VALUES
(1, 3, 'Степанов Марина Артемовна', 'Самый гейский гей', 2),
(2, 4, 'Третьяков Никандр Аркадьевич', 'Оперный певец', 5),
(3, 7, 'Дружинина Аполлинария Владиславовна', 'Балерина', 1),
(4, 10, 'Дружинин Кирилл Данилович', 'Балерин', 2),
(5, 32, 'Филиппова Казимира Владимировна', '8', 8),
(6, 5, 'Мухамедшин Арсений Ильдарович', 'Господин', 111),
(9, 11, '12', '13', 14);

-- --------------------------------------------------------

--
-- Структура таблицы `билет`
--

CREATE TABLE `билет` (
  `id_билет` tinyint(4) NOT NULL,
  `название` char(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `зал` char(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ряд` tinyint(4) DEFAULT NULL,
  `место` tinyint(4) DEFAULT NULL,
  `цена` smallint(6) DEFAULT NULL,
  `день` date DEFAULT NULL,
  `время` time DEFAULT NULL,
  `продолжительность` time DEFAULT NULL,
  `постановшик` char(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `id_зал` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `зал`
--

CREATE TABLE `зал` (
  `Спектакль` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_зал` tinyint(4) NOT NULL,
  `зал` char(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `свободные места` smallint(6) DEFAULT NULL,
  `територия` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `цена` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `зал`
--

INSERT INTO `зал` (`Спектакль`, `id_зал`, `зал`, `свободные места`, `територия`, `цена`) VALUES
('стандарт', 1, 'Партер', 28, 'Фиолетовый', 2500),
('стандарт', 2, 'Партер', 116, 'Красный', 2900),
('стандарт', 3, 'Партер', 76, 'Оранжевый', 3000),
('стандарт', 4, 'Ложа', 10, 'Красный', 2900),
('стандарт', 5, 'Ложа', 10, 'Оранжевый', 2500),
('стандарт', 6, 'Полукруг', 18, 'Красный', 2800),
('стандарт', 7, 'Полукруг', 56, 'Оранжевый', 2400),
('стандарт', 8, 'Амфитеатр', 29, 'Красный', 2900),
('стандарт', 9, 'Амфитеатр', 106, 'Оранжевый', 2000),
('стандарт', 10, 'Бельэтаж', 58, 'Оранжевый', 1800),
('стандарт', 11, 'Бельэтаж', 141, 'Зелёный', 1500),
('стандарт', 12, 'Бельэтаж', 14, 'Синий', 1250),
('стандарт', 13, 'Балкон', 17, 'Зелёный', 1000),
('стандарт', 14, 'Балкон', 147, 'Синий', 300);

-- --------------------------------------------------------

--
-- Структура таблицы `основание`
--

CREATE TABLE `основание` (
  `id_основа` tinyint(4) NOT NULL,
  `название` char(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `свободные места` smallint(6) DEFAULT NULL,
  `минимальная_цена` smallint(6) DEFAULT NULL,
  `максимальная_цена` smallint(6) DEFAULT NULL,
  `день` date DEFAULT NULL,
  `время` time DEFAULT NULL,
  `продолжительность` time DEFAULT NULL,
  `постановшик` char(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `основание`
--

INSERT INTO `основание` (`id_основа`, `название`, `свободные места`, `минимальная_цена`, `максимальная_цена`, `день`, `время`, `продолжительность`, `постановшик`) VALUES
(0, 'test', 11, 500, 2500, '2021-03-19', '12:00:00', '01:46:51', 'Mukhamedshin A.I.');

-- --------------------------------------------------------

--
-- Структура таблицы `работа в спектакле`
--

CREATE TABLE `работа в спектакле` (
  `id_выступления` tinyint(4) NOT NULL,
  `id_актёра` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `спектакли`
--

CREATE TABLE `спектакли` (
  `id_выступления` tinyint(4) NOT NULL,
  `название` char(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `свободные места` smallint(6) NOT NULL,
  `минимальная цена` smallint(6) NOT NULL,
  `максимальная цена` smallint(6) NOT NULL,
  `день` date NOT NULL,
  `время` time NOT NULL,
  `продолжительность` time NOT NULL,
  `постановшик` char(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `описание` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `актёры` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_залl` tinyint(4) NOT NULL,
  `id_основание` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `спектакли`
--

INSERT INTO `спектакли` (`id_выступления`, `название`, `свободные места`, `минимальная цена`, `максимальная цена`, `день`, `время`, `продолжительность`, `постановшик`, `описание`, `актёры`, `id_залl`, `id_основание`) VALUES
(8, 'Царская невеста', 79, 500, 5000, '2021-03-19', '12:00:00', '01:46:51', 'Mukhamedshin A.I.', 'Аниме в фирменной обёртке с нотками оптимизма', 'Степанова Марина Артемовна', 1, 0);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `пользователи`
--
ALTER TABLE `пользователи`
  ADD PRIMARY KEY (`id_пользователя`);

--
-- Индексы таблицы `актёры`
--
ALTER TABLE `актёры`
  ADD PRIMARY KEY (`id_актёра`);

--
-- Индексы таблицы `билет`
--
ALTER TABLE `билет`
  ADD PRIMARY KEY (`id_билет`,`id_зал`),
  ADD KEY `fk_ticket_hall1_idx` (`id_зал`);

--
-- Индексы таблицы `зал`
--
ALTER TABLE `зал`
  ADD PRIMARY KEY (`id_зал`);

--
-- Индексы таблицы `основание`
--
ALTER TABLE `основание`
  ADD PRIMARY KEY (`id_основа`);

--
-- Индексы таблицы `работа в спектакле`
--
ALTER TABLE `работа в спектакле`
  ADD PRIMARY KEY (`id_выступления`,`id_актёра`),
  ADD KEY `fk_performance_has_actors_actors1_idx` (`id_актёра`),
  ADD KEY `fk_performance_has_actors_performance_idx` (`id_выступления`);

--
-- Индексы таблицы `спектакли`
--
ALTER TABLE `спектакли`
  ADD PRIMARY KEY (`id_выступления`,`id_основание`),
  ADD KEY `fk_performance_hall1_idx` (`id_залl`),
  ADD KEY `fk_performance_main1_idx` (`id_основание`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `пользователи`
--
ALTER TABLE `пользователи`
  MODIFY `id_пользователя` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `актёры`
--
ALTER TABLE `актёры`
  MODIFY `id_актёра` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `билет`
--
ALTER TABLE `билет`
  ADD CONSTRAINT `fk_ticket_hall1` FOREIGN KEY (`id_зал`) REFERENCES `зал` (`id_зал`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `работа в спектакле`
--
ALTER TABLE `работа в спектакле`
  ADD CONSTRAINT `fk_performance_has_actors_actors1` FOREIGN KEY (`id_актёра`) REFERENCES `актёры` (`id_актёра`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_performance_has_actors_performance` FOREIGN KEY (`id_выступления`) REFERENCES `спектакли` (`id_выступления`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `спектакли`
--
ALTER TABLE `спектакли`
  ADD CONSTRAINT `fk_performance_hall1` FOREIGN KEY (`id_залl`) REFERENCES `зал` (`id_зал`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_performance_main1` FOREIGN KEY (`id_основание`) REFERENCES `основание` (`id_основа`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
