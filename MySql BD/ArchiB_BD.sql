-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 16 mai 2022 à 19:00
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ArchiB_BD`
--

-- --------------------------------------------------------

--
-- Structure de la table `Client`
--

DROP TABLE IF EXISTS `Client`;
CREATE TABLE IF NOT EXISTS `Client` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) NOT NULL,
  `Tel` varchar(255) NOT NULL,
  `Utilisateur` varchar(255) NOT NULL,
  `Mdp` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `Client`
--

INSERT INTO `Client` (`Id`, `Nom`, `Tel`, `Utilisateur`, `Mdp`) VALUES
(1, 'strange', '03366955478', 'user', 'user'),
(2, 'julio', '033456787964', 'julio', 'julio'),
(3, 'berziky', '03345655465', 'berziky@gmail.com', 'berziky'),
(4, 'zefa', '0331548', 'user@example.com', 'zefa'),
(5, 'fetra', '0331154795', 'fetrajuliio@gmail.com', 'fetra'),
(6, 'zily', '0331159745', 'zily@gmail.com', 'zily'),
(7, 'berziky', '0311456987', 'berziky@gmail.com', 'berziky');

-- --------------------------------------------------------

--
-- Structure de la table `finance`
--

DROP TABLE IF EXISTS `finance`;
CREATE TABLE IF NOT EXISTS `finance` (
  `dep` int(11) NOT NULL,
  `act` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `cap` int(11) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `finance`
--

INSERT INTO `finance` (`dep`, `act`, `date`, `cap`, `id`) VALUES
(1500, 1300, '2022-03-17 00:00:00', 100000, 1),
(0, 1354, '2022-03-01 00:00:00', 100000, 2),
(0, 145556, '2022-03-17 00:00:00', 100000, 3),
(0, 145556, '2022-03-17 00:00:00', 100000, 4),
(0, 145556, '2022-03-17 00:00:00', 100000, 5),
(0, 145556, '2022-03-17 00:00:00', 100000, 6),
(0, 145556, '2022-03-17 00:00:00', 100000, 7),
(0, 145556, '2022-03-17 00:00:00', 100000, 8);

-- --------------------------------------------------------

--
-- Structure de la table `Produit`
--

DROP TABLE IF EXISTS `Produit`;
CREATE TABLE IF NOT EXISTS `Produit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) NOT NULL,
  `qte` int(11) NOT NULL,
  `prix` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `Produit`
--

INSERT INTO `Produit` (`id`, `Nom`, `qte`, `prix`) VALUES
(1, 'Vilbrequin', 15, 1530000),
(2, 'turbo', 36, 1200000),
(3, 'cle', 0, 50000),
(4, 'pneu', 142, 140000),
(6, 'Moteur', 3, 5000000),
(8, 'Train Roulant', 6, 1500000),
(9, 'jonte', 650, 250000);

-- --------------------------------------------------------

--
-- Structure de la table `vente`
--

DROP TABLE IF EXISTS `vente`;
CREATE TABLE IF NOT EXISTS `vente` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idcl` int(11) NOT NULL,
  `idpr` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `valide` int(11) NOT NULL,
  `nbr` int(11) NOT NULL,
  `prixtotal` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `vente`
--

INSERT INTO `vente` (`id`, `idcl`, `idpr`, `date`, `valide`, `nbr`, `prixtotal`) VALUES
(1, 1, 1, '2022-03-14 00:00:00', 1, 0, 0),
(2, 1, 2, '2022-03-14 00:00:00', 1, 17, 0),
(3, 1, 2, '2022-03-14 19:10:49', 2, 18, 0),
(4, 1, 1, '2022-03-14 19:19:40', 1, 5, 0),
(5, 1, 2, '2022-03-14 19:29:44', 2, 18, 0),
(6, 1, 2, '2022-03-14 19:42:33', 2, 14, 0),
(7, 1, 6, '2022-03-14 20:13:50', 2, 1, 0),
(8, 1, 2, '2022-03-14 20:23:32', 0, 17, 20400000),
(9, 1, 2, '2022-03-15 09:44:38', 0, 11, 13200000),
(10, 1, 4, '2022-03-15 09:49:50', 0, 12, 1680000),
(11, 1, 9, '2022-03-15 09:51:11', 0, 16, 4000000),
(12, 1, 2, '2022-03-15 09:57:21', 0, 16, 19200000),
(13, 1, 2, '2022-03-15 09:59:43', 0, 16, 19200000),
(14, 1, 1, '2022-03-16 08:24:05', 1, 4, 6120000),
(15, 1, 2, '2022-03-16 08:26:28', 1, 15, 18000000),
(16, 1, 1, '2022-03-16 09:13:52', 1, 4, 6120000),
(17, 2, 1, '2022-03-16 16:16:28', 1, 1, 1530000),
(18, 2, 1, '2022-03-16 16:18:53', 1, 1, 1530000),
(19, 2, 1, '2022-03-17 00:00:00', 0, 13, 145556),
(20, 6, 4, '2022-05-16 19:56:48', 0, 52, 7280000);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
