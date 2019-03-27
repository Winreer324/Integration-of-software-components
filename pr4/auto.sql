-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Мар 27 2019 г., 09:55
-- Версия сервера: 10.1.36-MariaDB
-- Версия PHP: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `auto`
--

-- --------------------------------------------------------

--
-- Структура таблицы `auto`
--

CREATE TABLE `auto` (
  `Auto_ID` int(11) NOT NULL,
  `Firma` varchar(255) COLLATE utf8_bin NOT NULL,
  `Model` varchar(255) COLLATE utf8_bin NOT NULL,
  `Number` varchar(255) COLLATE utf8_bin NOT NULL,
  `Price` double NOT NULL,
  `Speed` double NOT NULL,
  `Motor_ID` int(11) NOT NULL,
  `Body_ID` int(11) NOT NULL,
  `Wheel_ID` int(11) NOT NULL,
  `Door_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Дамп данных таблицы `auto`
--

INSERT INTO `auto` (`Auto_ID`, `Firma`, `Model`, `Number`, `Price`, `Speed`, `Motor_ID`, `Body_ID`, `Wheel_ID`, `Door_ID`) VALUES
(1, 'Nissan', 'v4', 'a777aa', 2364, 290, 1, 2, 1, 2),
(2, 'Audi', 'GT-4', 'a666aa', 300, 200, 3, 3, 3, 3),
(3, 'Reno', 'MV', 'a444aa', 3500, 300, 2, 1, 2, 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `auto`
--
ALTER TABLE `auto`
  ADD PRIMARY KEY (`Auto_ID`),
  ADD UNIQUE KEY `Motor_ID` (`Motor_ID`,`Body_ID`,`Wheel_ID`,`Door_ID`),
  ADD KEY `Body_ID` (`Body_ID`),
  ADD KEY `Wheel_ID` (`Wheel_ID`),
  ADD KEY `Door_ID` (`Door_ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `auto`
--
ALTER TABLE `auto`
  MODIFY `Auto_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `auto`
--
ALTER TABLE `auto`
  ADD CONSTRAINT `auto_ibfk_2` FOREIGN KEY (`Body_ID`) REFERENCES `body` (`Body_ID`),
  ADD CONSTRAINT `auto_ibfk_3` FOREIGN KEY (`Wheel_ID`) REFERENCES `wheel` (`Wheel_ID`),
  ADD CONSTRAINT `auto_ibfk_4` FOREIGN KEY (`Door_ID`) REFERENCES `door` (`Door_ID`),
  ADD CONSTRAINT `auto_ibfk_5` FOREIGN KEY (`Motor_ID`) REFERENCES `motor` (`Motor_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
