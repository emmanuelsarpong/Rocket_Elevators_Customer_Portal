-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 09, 2021 at 08:54 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `customer_portal`
--

-- --------------------------------------------------------

--
-- Table structure for table `addresses`
--

CREATE TABLE `addresses` (
  `id` bigint(20) NOT NULL,
  `building_id` bigint(20) DEFAULT NULL,
  `customer_id` bigint(20) DEFAULT NULL,
  `type_of_address` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `entity` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `number_and_street` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `suite_or_apartment` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `city` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `postal_code` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `country` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `notes` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `latitude` float DEFAULT NULL,
  `longitude` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ar_internal_metadata`
--

CREATE TABLE `ar_internal_metadata` (
  `key` varchar(255) CHARACTER SET utf8 NOT NULL,
  `value` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `batteries`
--

CREATE TABLE `batteries` (
  `id` bigint(20) NOT NULL,
  `building_id` bigint(20) DEFAULT NULL,
  `employee_id` bigint(20) DEFAULT NULL,
  `battery_type` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `battery_status` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `date_of_commissioning` date DEFAULT NULL,
  `date_of_last_inspection` date DEFAULT NULL,
  `certificate_of_operations` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `information` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `notes` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `batteries`
--

INSERT INTO `batteries` (`id`, `building_id`, `employee_id`, `battery_type`, `battery_status`, `date_of_commissioning`, `date_of_last_inspection`, `certificate_of_operations`, `information`, `notes`, `created_at`, `updated_at`) VALUES
(1, 1, NULL, 'Residential', 'Inactive', '2021-11-13', '2021-11-04', 'Candice B. DePlace', 'Placeat exercitationem voluptas.', 'Dolores assumenda nulla.', '2021-07-19 02:15:14', '2021-07-19 02:15:14'),
(2, 2, NULL, 'Hybrid', 'Inactive', '2021-11-15', '2021-06-18', 'Sue Ridge', 'Repellat sed numquam.', 'Officiis animi error.', '2021-07-19 02:15:18', '2021-07-19 02:15:18'),
(3, 3, NULL, 'Commercial', 'Inactive', '2021-10-03', '2021-10-03', 'Emile Eaton', 'Eos ipsa consequatur.', 'Delectus ipsa eius.', '2021-07-19 02:15:20', '2021-07-19 02:15:20'),
(4, 4, NULL, 'Commercial', 'Inactive', '2021-10-05', '2021-09-15', 'Winnie Dipoo', 'Ab laborum voluptates.', 'Et sapiente facilis.', '2021-07-19 02:15:23', '2021-07-19 02:15:23');

-- --------------------------------------------------------

--
-- Table structure for table `buildings`
--

CREATE TABLE `buildings` (
  `id` bigint(20) NOT NULL,
  `customer_id` bigint(20) DEFAULT NULL,
  `admin_contact_id` bigint(20) DEFAULT NULL,
  `technical_contact_id` bigint(20) DEFAULT NULL,
  `administrator_full_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `administrator_email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `administrator_phone_number` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `technical_contact_full_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `technical_contact_email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `technical_contact_phone` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `building_detail_id` bigint(20) DEFAULT NULL,
  `address_id` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buildings`
--

INSERT INTO `buildings` (`id`, `customer_id`, `admin_contact_id`, `technical_contact_id`, `administrator_full_name`, `administrator_email`, `administrator_phone_number`, `technical_contact_full_name`, `technical_contact_email`, `technical_contact_phone`, `created_at`, `updated_at`, `building_detail_id`, `address_id`) VALUES
(1, NULL, NULL, NULL, 'Rev. Sol Hahn', 'denise@dach.biz', '322-584-1785', 'Laurice Hudson', 'gordon_bergnaum@schmitt-dickinson.co', '851-091-4188', '2021-07-19 02:15:14', '2021-07-19 02:15:14', NULL, NULL),
(2, NULL, NULL, NULL, 'Ramiro Moore', 'earle.waelchi@feeney.info', '776.844.1537', 'Shayne DuBuque', 'candi.goldner@connelly.name', '446.578.3164', '2021-07-19 02:15:17', '2021-07-19 02:15:17', NULL, NULL),
(3, NULL, NULL, NULL, 'The Hon. Shakita Mills', 'angeline.runte@wisoky.info', '1-622-618-8013', 'Everette Vandervort', 'bernie.kihn@stanton-schaefer.info', '119.566.6374', '2021-07-19 02:15:20', '2021-07-19 02:15:20', NULL, NULL),
(4, NULL, NULL, NULL, 'Kirstin Grady', 'deon.rath@kuhn.io', '1-983-532-7383', 'Colby Kutch', 'gennie.schuppe@stark.com', '256.072.8255', '2021-07-19 02:15:23', '2021-07-19 02:15:23', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `building_details`
--

CREATE TABLE `building_details` (
  `id` bigint(20) NOT NULL,
  `building_id` bigint(20) DEFAULT NULL,
  `information_key` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `value` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `columns`
--

CREATE TABLE `columns` (
  `id` bigint(20) NOT NULL,
  `battery_id` bigint(20) DEFAULT NULL,
  `column_type` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `column_status` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `number_of_floors_served` int(11) DEFAULT NULL,
  `information` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `notes` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `columns`
--

INSERT INTO `columns` (`id`, `battery_id`, `column_type`, `column_status`, `number_of_floors_served`, `information`, `notes`, `created_at`, `updated_at`) VALUES
(1, 1, 'Commercial', 'Inactive', 1, 'Corporis nihil voluptas.', 'Quidem ea vero.', '2021-07-19 02:15:14', '2021-07-19 02:15:14'),
(2, 1, 'Corporate', 'Inactive', 1, 'Dolores cupiditate eveniet.', 'Distinctio eum maxime.', '2021-07-19 02:15:15', '2021-07-19 02:15:15'),
(3, 1, 'Hybrid', 'Inactive', 1, 'Iure commodi ut.', 'Odit nemo aliquam.', '2021-07-19 02:15:16', '2021-07-19 02:15:16'),
(4, 2, 'Commercial', 'Inactive', 1, 'Animi aut iste.', 'Suscipit amet consequuntur.', '2021-07-19 02:15:18', '2021-07-19 02:15:18'),
(5, 2, 'Residential', 'Inactive', 1, 'Voluptatem repudiandae quas.', 'Ad debitis facilis.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(6, 2, 'Hybrid', 'Inactive', 1, 'Est esse et.', 'Nihil vero aut.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(7, 3, 'Commercial', 'Inactive', 1, 'Voluptas assumenda eligendi.', 'Cumque et ea.', '2021-07-19 02:15:20', '2021-07-19 02:15:20'),
(8, 3, 'Residential', 'Active', 1, 'Quo voluptates sed.', 'Commodi et non.', '2021-07-19 02:15:21', '2021-07-19 02:15:21'),
(9, 3, 'Corporate', 'Active', 1, 'Enim libero quod.', 'Et doloribus corrupti.', '2021-07-19 02:15:22', '2021-07-19 02:15:22'),
(10, 4, 'Commercial', 'Active', 1, 'Et et cum.', 'Exercitationem velit commodi.', '2021-07-19 02:15:23', '2021-07-19 02:15:23'),
(11, 4, 'Hybrid', 'Active', 1, 'Modi expedita repellendus.', 'Quam eligendi impedit.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(12, 4, 'Residential', 'Active', 1, 'Aliquam sed aut.', 'Aut harum autem.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(13, 5, 'Commercial', 'Inactive', 1, 'Sequi nostrum culpa.', 'Ullam voluptate et.', '2021-07-19 02:15:25', '2021-07-19 02:15:25'),
(14, 5, 'Corporate', 'Inactive', 1, 'Vero dolorem iure.', 'Molestiae ipsum sed.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(15, 5, 'Commercial', 'Active', 1, 'Modi nihil quae.', 'Quia asperiores ad.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(16, 6, 'Commercial', 'Inactive', 1, 'Dignissimos est alias.', 'Ea libero quidem.', '2021-07-19 02:15:27', '2021-07-19 02:15:27'),
(17, 6, 'Commercial', 'Active', 1, 'Velit quos consectetur.', 'Est quis nisi.', '2021-07-19 02:15:29', '2021-07-19 02:15:29');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `id` bigint(20) NOT NULL,
  `user_id` bigint(20) DEFAULT NULL,
  `company_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `company_contact_full_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `company_contact_phone` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `company_contact_email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `company_description` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `technical_authority_full_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `technical_authority_phone_number` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `technical_manager_email_service` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `address_id` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `elevators`
--

CREATE TABLE `elevators` (
  `id` bigint(20) NOT NULL,
  `column_id` bigint(20) DEFAULT NULL,
  `serial_number` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `elevator_model` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `elevator_type` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `elevator_status` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `date_of_commissioning` date DEFAULT NULL,
  `date_of_last_inspection` date DEFAULT NULL,
  `certificate_of_inspection` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `information` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `notes` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `elevators`
--

INSERT INTO `elevators` (`id`, `column_id`, `serial_number`, `elevator_model`, `elevator_type`, `elevator_status`, `date_of_commissioning`, `date_of_last_inspection`, `certificate_of_inspection`, `information`, `notes`, `created_at`, `updated_at`) VALUES
(1, 1, '450750YH3TY885868', 'Cube', 'Commercial', 'Active', '2021-11-01', '2021-08-13', 'Juana Bea', 'Quis est enim.', 'Dolores autem similique.', '2021-07-19 02:15:14', '2021-07-19 02:15:14'),
(2, 1, 'T3I4L398I00L40653', 'Accord', 'Hybrid', 'Active', '2021-12-06', '2021-08-24', 'Pearl E White', 'Id consequatur incidunt.', 'Cumque quis velit.', '2021-07-19 02:15:14', '2021-07-19 02:15:14'),
(3, 1, 'WO31U1D6580619916', 'S5', 'Commercial', 'Inactive', '2021-08-23', '2021-07-28', 'Didi Reelydoit', 'Tempora nihil sunt.', 'Non enim nihil.', '2021-07-19 02:15:14', '2021-07-19 02:15:14'),
(4, 1, '16V457I52LJQ60290', 'Pathfiner', 'Residential', 'Inactive', '2021-08-25', '2021-09-23', 'Anita Knapp', 'Laboriosam magni dolorum.', 'Possimus eius iure.', '2021-07-19 02:15:14', '2021-07-19 02:15:14'),
(5, 2, 'L61117THLRCY60353', 'Accord', 'Corporate', 'Inactive', '2021-07-04', '2021-06-19', 'Parker Carr', 'Dolores nulla eligendi.', 'Voluptatem atque dolore.', '2021-07-19 02:15:15', '2021-07-19 02:15:15'),
(6, 2, '1Q238Y2RQ10170358', 'Corolla', 'Residential', 'Inactive', '2021-11-15', '2021-08-14', 'Mort Tallity', 'Unde doloremque pariatur.', 'Dolorum ea facere.', '2021-07-19 02:15:15', '2021-07-19 02:15:15'),
(7, 2, 'UAL863IRN1YJ18665', 'Cube', 'Residential', 'Active', '2021-07-06', '2021-07-15', 'Bill Loney', 'Est rerum enim.', 'Officiis sunt voluptates.', '2021-07-19 02:15:15', '2021-07-19 02:15:15'),
(8, 2, 'U6718KZR7RKR35296', 'A8', 'Hybrid', 'Active', '2021-08-06', '2021-09-12', 'Easton West', 'Illo pariatur enim.', 'Illo veniam voluptate.', '2021-07-19 02:15:15', '2021-07-19 02:15:15'),
(9, 3, 'Y43899FDVC0340716', 'Camero', 'Corporate', 'Active', '2021-06-28', '2021-07-12', 'Les Moore', 'Earum perferendis voluptatem.', 'Itaque iusto maiores.', '2021-07-19 02:15:16', '2021-07-19 02:15:16'),
(10, 3, 'J02W43LWC5WE30129', 'Corolla', 'Residential', 'Active', '2021-07-09', '2021-11-27', 'Jack Dupp', 'Similique reprehenderit natus.', 'Illum occaecati facere.', '2021-07-19 02:15:16', '2021-07-19 02:15:16'),
(11, 3, 'T936J3G214O832845', 'Malibu', 'Commercial', 'Inactive', '2021-06-19', '2021-07-25', 'Winnie Dipoo', 'Consectetur sit debitis.', 'Porro eligendi aliquid.', '2021-07-19 02:15:16', '2021-07-19 02:15:16'),
(12, 3, 'B3B2TK2FPTIO91590', 'Camry', 'Commercial', 'Active', '2021-11-06', '2021-08-22', 'Rusty Fossat', 'Tenetur quidem consequuntur.', 'Eius nemo et.', '2021-07-19 02:15:16', '2021-07-19 02:15:16'),
(13, 4, 'WW3UNL5T0Y0P37064', 'Verano', 'Hybrid', 'Inactive', '2021-07-12', '2021-12-04', 'Darrell B. Moore', 'Voluptates voluptatibus pariatur.', 'Sunt quas reiciendis.', '2021-07-19 02:15:18', '2021-07-19 02:15:18'),
(14, 4, 'A0RR54145Z0R77082', 'Ram', 'Commercial', 'Inactive', '2021-12-25', '2021-12-27', 'Robin Banks', 'Quos pariatur cupiditate.', 'Id fuga aut.', '2021-07-19 02:15:18', '2021-07-19 02:15:18'),
(15, 4, '7K5Q3ZI46D0675448', 'Challenger', 'Residential', 'Active', '2021-12-17', '2021-09-19', 'Ali Gaither', 'Laboriosam ex odio.', 'Laudantium labore consequuntur.', '2021-07-19 02:15:18', '2021-07-19 02:15:18'),
(16, 4, 'SZZ6Q7PHX70N91231', 'Civic', 'Commercial', 'Active', '2021-06-30', '2021-08-11', 'Kristie Hannity', 'Ducimus ea commodi.', 'Consequatur non occaecati.', '2021-07-19 02:15:18', '2021-07-19 02:15:18'),
(17, 5, '1Y866R98XZL602634', 'Camry', 'Residential', 'Inactive', '2021-12-19', '2021-12-06', 'Marshall Law', 'Eum rem aut.', 'Magnam rerum nisi.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(18, 5, '7793VOT5BZ0A21428', 'Camero', 'Commercial', 'Active', '2021-08-23', '2021-08-08', 'Park A. Studebaker', 'Necessitatibus quasi pariatur.', 'Dolor exercitationem libero.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(19, 5, '25W15ZOL5G0801375', 'M3', 'Commercial', 'Active', '2021-07-06', '2021-09-06', 'Mel Loewe', 'Repudiandae voluptas fuga.', 'Officia rem illum.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(20, 5, 'BGUHY2TCR4F786547', 'Silverado', 'Commercial', 'Active', '2021-08-07', '2021-11-30', 'Zoltan Pepper', 'Sed facilis et.', 'Doloremque et sint.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(21, 6, 'W1LW2290BNX376090', 'Prius', 'Residential', 'Inactive', '2021-12-23', '2021-06-29', 'Bo Nessround', 'Perferendis dolores dolorem.', 'Harum ut sunt.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(22, 6, 'JPG9J4978PQ214546', 'Accord', 'Residential', 'Active', '2021-09-01', '2021-11-09', 'Tom Katt', 'Quam qui quaerat.', 'Et aliquam pariatur.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(23, 6, 'F170P5J5700T72349', 'X1', 'Hybrid', 'Active', '2021-07-02', '2021-09-24', 'Ray Gunn', 'Quos molestiae et.', 'Corporis quas deleniti.', '2021-07-19 02:15:19', '2021-07-19 02:15:19'),
(24, 6, 'S12DC63TYCF503510', 'MKZ', 'Residential', 'Active', '2021-11-22', '2021-07-17', 'Ima Lytle Teapot', 'Dolor aperiam ipsam.', 'Voluptate ut tenetur.', '2021-07-19 02:15:20', '2021-07-19 02:15:20'),
(25, 7, '6FT60M64FD0821343', 'Navigator', 'Corporate', 'Inactive', '2021-09-20', '2021-07-28', 'Ben D. Fender', 'Eius delectus vel.', 'Repellat eligendi aut.', '2021-07-19 02:15:20', '2021-07-19 02:15:20'),
(26, 7, 'ZJ5DR90713FB57040', 'Camry', 'Commercial', 'Inactive', '2021-07-02', '2021-11-29', 'Patton Down DeHatches', 'Nostrum minus est.', 'Quo voluptatem unde.', '2021-07-19 02:15:20', '2021-07-19 02:15:20'),
(27, 7, 'C21S9MC72YR076605', 'Camero', 'Hybrid', 'Inactive', '2021-08-19', '2021-11-25', 'Sue Flay', 'Eum omnis ea.', 'At est consequatur.', '2021-07-19 02:15:20', '2021-07-19 02:15:20'),
(28, 7, 'YJR9805Q0TT161622', 'Riveria', 'Residential', 'Active', '2021-07-06', '2021-08-05', 'Sue Ridge', 'Eos molestias odio.', 'Distinctio dicta tenetur.', '2021-07-19 02:15:20', '2021-07-19 02:15:20'),
(29, 8, '6936ARNK0JPS94747', 'Odyssey', 'Residential', 'Active', '2021-12-04', '2021-06-21', 'Myles Long', 'Ab quis eum.', 'Doloremque illo rerum.', '2021-07-19 02:15:21', '2021-07-19 02:15:21'),
(30, 8, 'BY2J3D73C7GC44701', 'Fiesta', 'Commercial', 'Inactive', '2021-08-09', '2021-11-04', 'Tom Katz', 'Animi qui et.', 'Ipsum eaque pariatur.', '2021-07-19 02:15:21', '2021-07-19 02:15:21'),
(31, 8, '2O07RO45IN0Q53770', 'X3', 'Corporate', 'Inactive', '2021-11-28', '2021-07-30', 'Olive Green', 'Itaque suscipit molestiae.', 'Veniam tenetur praesentium.', '2021-07-19 02:15:21', '2021-07-19 02:15:21'),
(32, 8, '804YOPDK3R0602614', 'Accord', 'Corporate', 'Inactive', '2021-08-17', '2021-11-13', 'Homan Provement', 'Ut et vero.', 'Animi est culpa.', '2021-07-19 02:15:21', '2021-07-19 02:15:21'),
(33, 9, '2672M98F2Z0500796', 'Durango', 'Corporate', 'Inactive', '2021-12-26', '2021-09-22', 'Rob Banks', 'Praesentium atque sunt.', 'Voluptatem aut excepturi.', '2021-07-19 02:15:22', '2021-07-19 02:15:22'),
(34, 9, 'N9HP0U89JZ0J38212', 'M3', 'Commercial', 'Inactive', '2021-09-13', '2021-10-05', 'Sue Case', 'Sequi ipsa aspernatur.', 'Eum minus pariatur.', '2021-07-19 02:15:22', '2021-07-19 02:15:22'),
(35, 9, '97ZW3043HE0F09125', 'Civic', 'Residential', 'Inactive', '2021-08-07', '2021-12-24', 'Nick Ovtime', 'Quae molestias fugiat.', 'Possimus iste fuga.', '2021-07-19 02:15:22', '2021-07-19 02:15:22'),
(36, 9, 'JDO140B176IC48254', 'Regal', 'Corporate', 'Inactive', '2021-08-04', '2021-08-02', 'Art Exhibit', 'Dolorum veritatis nisi.', 'Molestiae aut vitae.', '2021-07-19 02:15:22', '2021-07-19 02:15:22'),
(37, 10, '5TI7MI8UL50662744', 'Camero', 'Corporate', 'Inactive', '2021-12-14', '2021-09-16', 'Ryan Carnation', 'Aut in sunt.', 'Pariatur voluptatum aut.', '2021-07-19 02:15:23', '2021-07-19 02:15:23'),
(38, 10, '8837NT5ZSB0T42008', 'Malibu', 'Commercial', 'Active', '2021-06-16', '2021-09-11', 'Kitty Katz', 'Nihil quae assumenda.', 'Velit eveniet exercitationem.', '2021-07-19 02:15:23', '2021-07-19 02:15:23'),
(39, 10, 'CX37SI9567JS42046', 'Enclave', 'Residential', 'Inactive', '2021-10-19', '2021-08-04', 'Al Dente', 'Omnis nam eaque.', 'Eos est nostrum.', '2021-07-19 02:15:23', '2021-07-19 02:15:23'),
(40, 10, '5MT9Q3F5990N49360', 'M3', 'Residential', 'Active', '2021-09-11', '2021-06-21', 'Ty Malone', 'Fugit dolore assumenda.', 'Necessitatibus nam enim.', '2021-07-19 02:15:23', '2021-07-19 02:15:23'),
(41, 11, 'JQ0R86ON500I85952', 'Altima', 'Corporate', 'Inactive', '2021-08-19', '2021-07-09', 'Frank Enstein', 'Eos voluptatem quod.', 'Ut officia magnam.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(42, 11, '93144RUL780C62751', 'Odyssey', 'Commercial', 'Inactive', '2021-09-08', '2021-08-30', 'Noah Riddle', 'Autem quisquam aliquid.', 'Quaerat quae natus.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(43, 11, '364505U9Y6H776618', 'Ram', 'Residential', 'Inactive', '2021-08-29', '2021-12-04', 'Phil A. Mignon', 'Fugit porro ad.', 'Delectus pariatur fugiat.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(44, 11, 'J5I7R6PMT10P91266', 'Navigator', 'Hybrid', 'Inactive', '2021-12-05', '2021-12-08', 'Joanna Hand', 'Mollitia quam reiciendis.', 'Consequuntur alias tenetur.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(45, 12, 'SSF8OG13MK0594451', 'Civic', 'Corporate', 'Inactive', '2021-07-31', '2021-12-05', 'Jay Bird', 'Dolores sit voluptas.', 'Eligendi iure voluptas.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(46, 12, 'WQ66DU46AS0856340', 'Altima', 'Hybrid', 'Inactive', '2021-10-03', '2021-12-20', 'Bob Sledd', 'Ut eius voluptatem.', 'Consectetur laudantium ab.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(47, 12, 'YUWA6660KIN755538', 'Prius', 'Commercial', 'Active', '2021-08-31', '2021-11-03', 'Barry Cade', 'Tempora laboriosam perspiciatis.', 'Cumque a ipsam.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(48, 12, 'D4RLE4N3C50687703', 'Riveria', 'Hybrid', 'Active', '2021-07-07', '2021-07-02', 'Ann Chovie', 'Quidem eaque optio.', 'Aliquid officiis quia.', '2021-07-19 02:15:24', '2021-07-19 02:15:24'),
(49, 13, 'NO164662P00O79250', 'F150', 'Commercial', 'Active', '2021-09-06', '2021-10-08', 'Nick L. Andime', 'Eos soluta minima.', 'Praesentium veritatis ullam.', '2021-07-19 02:15:25', '2021-07-19 02:15:25'),
(50, 13, '44VK0MH6S4X117185', 'F150', 'Hybrid', 'Active', '2021-08-30', '2021-08-23', 'Sarah Bellum', 'Sapiente autem numquam.', 'Minus aut voluptates.', '2021-07-19 02:15:25', '2021-07-19 02:15:25'),
(51, 13, '3G1R508CC5MV06909', 'Cube', 'Commercial', 'Active', '2021-08-21', '2021-12-29', 'Ivan Oder', 'Voluptatum et suscipit.', 'Unde laborum placeat.', '2021-07-19 02:15:25', '2021-07-19 02:15:25'),
(52, 13, 'Z9993M3JJ10N84382', 'F150', 'Corporate', 'Active', '2021-07-06', '2021-07-19', 'Candice B. Fureal', 'Occaecati doloremque ullam.', 'Omnis officiis maiores.', '2021-07-19 02:15:25', '2021-07-19 02:15:25'),
(53, 14, '50046YZH760538397', 'Riveria', 'Corporate', 'Inactive', '2021-08-18', '2021-11-29', 'Myles Long', 'Earum voluptatem et.', 'Fugit quaerat porro.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(54, 14, 'OWG8GJ6ADG0D02614', 'Regal', 'Residential', 'Inactive', '2021-12-29', '2021-09-16', 'Adam Sapple', 'Animi dicta totam.', 'Reprehenderit sint molestiae.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(55, 14, '26IHL6GU6IDL96924', 'Regal', 'Corporate', 'Inactive', '2021-11-05', '2021-08-06', 'Anita Bath', 'Itaque accusamus vero.', 'Itaque suscipit maiores.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(56, 14, '0M8P95G42UP253029', 'Riveria', 'Hybrid', 'Inactive', '2021-09-21', '2021-08-14', 'Lee Nover', 'Non qui rerum.', 'Laboriosam recusandae dolor.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(57, 15, '9X5GH72L640081200', 'MKX', 'Commercial', 'Inactive', '2021-12-25', '2021-09-03', 'Gladys C. Hughes', 'Voluptates voluptas quo.', 'Voluptas iusto unde.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(58, 15, 'P8751DZGN2EV60334', 'Prius', 'Residential', 'Inactive', '2021-10-24', '2021-10-26', 'Anna Mull', 'Tempora earum temporibus.', 'Nam possimus quia.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(59, 15, 'J1VM2U0RUM0503231', 'LaCrosse', 'Hybrid', 'Active', '2021-12-05', '2021-09-03', 'Rosie Peach', 'A explicabo ut.', 'Aut nihil consequatur.', '2021-07-19 02:15:26', '2021-07-19 02:15:26'),
(60, 15, 'Z74I01C5N00C11922', 'Navigator', 'Corporate', 'Inactive', '2021-12-19', '2021-09-08', 'Ken Oppenner', 'Culpa recusandae odit.', 'At temporibus rem.', '2021-07-19 02:15:27', '2021-07-19 02:15:27'),
(61, 16, '1K2TM8NJ0O0L99073', 'X3', 'Corporate', 'Active', '2021-08-23', '2021-10-24', 'Tate Urtots', 'Quibusdam dolorum assumenda.', 'Ut quia consequatur.', '2021-07-19 02:15:27', '2021-07-19 02:15:27'),
(62, 16, 'TNVO0345Y3G985640', 'Silverado', 'Corporate', 'Active', '2021-10-05', '2021-11-09', 'Bess Eaton', 'Aut quaerat asperiores.', 'Omnis quo voluptas.', '2021-07-19 02:15:27', '2021-07-19 02:15:27'),
(63, 16, '801673IX9X0Y01042', 'Camry', 'Residential', 'Active', '2021-07-12', '2021-08-13', 'Rowan Boatman', 'Maiores inventore molestiae.', 'Perspiciatis ullam fuga.', '2021-07-19 02:15:27', '2021-07-19 02:15:27'),
(64, 16, 'W86OFM0YN40P31733', 'Prius', 'Commercial', 'Inactive', '2021-09-20', '2021-08-29', 'Barb Dwyer', 'Ea accusamus fugit.', 'Quis ipsam et.', '2021-07-19 02:15:27', '2021-07-19 02:15:27'),
(65, 17, 'JORT0Q3C07S310479', 'MKX', 'Hybrid', 'Active', '2021-08-12', '2021-08-19', 'Ty Tannick', 'A occaecati recusandae.', 'Dolores molestiae excepturi.', '2021-07-19 02:15:29', '2021-07-19 02:15:29'),
(66, 17, '8Z94RYJ394U828353', 'Camero', 'Residential', 'Active', '2021-08-09', '2021-09-08', 'Anna Conda', 'Quod voluptate eum.', 'Placeat dolores quo.', '2021-07-19 02:15:29', '2021-07-19 02:15:29'),
(67, 17, '5B53PNYLISDY69218', 'Ram', 'Corporate', 'Inactive', '2021-12-03', '2021-12-04', 'Rosie Peach', 'A rerum itaque.', 'Consequatur natus voluptatem.', '2021-07-19 02:15:29', '2021-07-19 02:15:29'),
(68, 17, 'LD13Q30MS90R40857', 'S5', 'Corporate', 'Inactive', '2021-07-08', '2021-08-05', 'Megan Bacon', 'Aut optio explicabo.', 'Ipsam magni rem.', '2021-07-19 02:15:29', '2021-07-19 02:15:29');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `id` bigint(20) NOT NULL,
  `first_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `last_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `function` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `user_id` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `interventions`
--

CREATE TABLE `interventions` (
  `id` bigint(20) NOT NULL,
  `author` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `building_id` int(11) NOT NULL,
  `battery_id` int(11) DEFAULT NULL,
  `column_id` int(11) DEFAULT NULL,
  `elevator_id` int(11) DEFAULT NULL,
  `employee_id` int(11) DEFAULT NULL,
  `start_intervention` datetime DEFAULT NULL,
  `end_intervention` datetime DEFAULT NULL,
  `result` varchar(255) CHARACTER SET utf8 DEFAULT 'Incomplete',
  `report` text CHARACTER SET utf8 DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8 DEFAULT 'Pending',
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `interventions`
--

INSERT INTO `interventions` (`id`, `author`, `customer_id`, `building_id`, `battery_id`, `column_id`, `elevator_id`, `employee_id`, `start_intervention`, `end_intervention`, `result`, `report`, `status`, `created_at`, `updated_at`) VALUES
(1, 4, 4, 1, 1, 2, 1, NULL, NULL, NULL, NULL, 'Test first intervention', NULL, '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(2, 4, 4, 3, 2, 13, 10, NULL, NULL, NULL, NULL, 'Test intervention 2', NULL, '0001-01-01 00:00:00', '0001-01-01 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `leads`
--

CREATE TABLE `leads` (
  `id` bigint(20) NOT NULL,
  `full_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `business_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `project_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `department` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `project_description` text CHARACTER SET utf8 DEFAULT NULL,
  `message` text CHARACTER SET utf8 DEFAULT NULL,
  `attachment` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `user_id` bigint(20) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `quotes`
--

CREATE TABLE `quotes` (
  `id` bigint(20) NOT NULL,
  `user_id` bigint(20) DEFAULT NULL,
  `apartments` int(11) DEFAULT NULL,
  `floors` int(11) DEFAULT NULL,
  `basements` int(11) DEFAULT NULL,
  `businesses` int(11) DEFAULT NULL,
  `elevator_shafts` int(11) DEFAULT NULL,
  `parking_spaces` int(11) DEFAULT NULL,
  `occupants` int(11) DEFAULT NULL,
  `opening_hours` int(11) DEFAULT NULL,
  `product_line` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `install_fee` decimal(8,2) DEFAULT NULL,
  `total_price` decimal(8,2) DEFAULT NULL,
  `unit_price` int(11) DEFAULT NULL,
  `elevator_number` int(11) DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `building_type` varchar(255) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `schema_migrations`
--

CREATE TABLE `schema_migrations` (
  `version` varchar(255) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` bigint(20) NOT NULL,
  `first_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `last_name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `title` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `email` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `encrypted_password` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `reset_password_token` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `reset_password_sent_at` datetime DEFAULT NULL,
  `remember_created_at` datetime DEFAULT NULL,
  `is_admin` tinyint(1) DEFAULT 0,
  `is_employee` tinyint(1) DEFAULT 0,
  `is_user` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `first_name`, `last_name`, `title`, `created_at`, `updated_at`, `email`, `encrypted_password`, `reset_password_token`, `reset_password_sent_at`, `remember_created_at`, `is_admin`, `is_employee`, `is_user`) VALUES
(2, 'Alex', 'Duck', NULL, '2001-01-01 00:00:00', '0001-01-01 00:00:00', 'alex-duck@gmail.com', '10000.DZXnrU/mrzi4XdDluyUBvQ==.xz7u3pNRvZYHQYUPbd036bKmVOVC5AWtDzqlIv75974=', NULL, NULL, NULL, NULL, NULL, 1),
(3, 'Spencer', 'Dog', NULL, '0001-01-01 00:00:00', '0001-01-01 00:00:00', 'spencer@gmail.com', '10000.nkEP13oWeKu5HjDMGT6HPw==.jjv6c2AcoPqKm592QByQgo73d2dxUpS7EHOQz2EcdrQ=', NULL, NULL, NULL, NULL, NULL, 1),
(4, 'Spencer', 'Scot', NULL, '0001-01-01 00:00:00', '0001-01-01 00:00:00', 'spencerscot@gmail.com', '10000.rUNF+eYqzhVkgr7IyvVGRQ==.YxpGHn1lV43pWms8z/qAEzRdpbNoDoU2FKHHYA4qSZk=', NULL, NULL, NULL, NULL, NULL, 1
)ON DUPLICATE KEY UPDATE MatchUrl = ?MatchUrl;

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20210801094839_InitialCreate', '3.1.10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_addresses_on_building_id` (`building_id`),
  ADD KEY `index_addresses_on_customer_id` (`customer_id`);

--
-- Indexes for table `ar_internal_metadata`
--
ALTER TABLE `ar_internal_metadata`
  ADD PRIMARY KEY (`key`);

--
-- Indexes for table `batteries`
--
ALTER TABLE `batteries`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_batteries_on_building_id` (`building_id`),
  ADD KEY `index_batteries_on_employee_id` (`employee_id`);

--
-- Indexes for table `buildings`
--
ALTER TABLE `buildings`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_buildings_on_address_id` (`address_id`),
  ADD KEY `index_buildings_on_admin_contact_id` (`admin_contact_id`),
  ADD KEY `index_buildings_on_building_detail_id` (`building_detail_id`),
  ADD KEY `index_buildings_on_customer_id` (`customer_id`),
  ADD KEY `index_buildings_on_technical_contact_id` (`technical_contact_id`);

--
-- Indexes for table `building_details`
--
ALTER TABLE `building_details`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_building_details_on_building_id` (`building_id`);

--
-- Indexes for table `columns`
--
ALTER TABLE `columns`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_columns_on_battery_id` (`battery_id`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_customers_on_address_id` (`address_id`),
  ADD KEY `index_customers_on_user_id` (`user_id`);

--
-- Indexes for table `elevators`
--
ALTER TABLE `elevators`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_elevators_on_column_id` (`column_id`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_employees_on_user_id` (`user_id`);

--
-- Indexes for table `interventions`
--
ALTER TABLE `interventions`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `leads`
--
ALTER TABLE `leads`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_leads_on_user_id` (`user_id`);

--
-- Indexes for table `quotes`
--
ALTER TABLE `quotes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `index_quotes_on_user_id` (`user_id`);

--
-- Indexes for table `schema_migrations`
--
ALTER TABLE `schema_migrations`
  ADD PRIMARY KEY (`version`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `index_users_on_email` (`email`),
  ADD UNIQUE KEY `index_users_on_reset_password_token` (`reset_password_token`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addresses`
--
ALTER TABLE `addresses`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `batteries`
--
ALTER TABLE `batteries`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `buildings`
--
ALTER TABLE `buildings`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `building_details`
--
ALTER TABLE `building_details`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `columns`
--
ALTER TABLE `columns`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `elevators`
--
ALTER TABLE `elevators`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `interventions`
--
ALTER TABLE `interventions`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `leads`
--
ALTER TABLE `leads`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `quotes`
--
ALTER TABLE `quotes`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `fk_rails_a9ab2347cc` FOREIGN KEY (`building_id`) REFERENCES `buildings` (`id`),
  ADD CONSTRAINT `fk_rails_d5f9efddd3` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`id`);

--
-- Constraints for table `buildings`
--
ALTER TABLE `buildings`
  ADD CONSTRAINT `fk_rails_6f76cebe7f` FOREIGN KEY (`admin_contact_id`) REFERENCES `employees` (`id`),
  ADD CONSTRAINT `fk_rails_f7dd45df76` FOREIGN KEY (`technical_contact_id`) REFERENCES `employees` (`id`);

--
-- Constraints for table `building_details`
--
ALTER TABLE `building_details`
  ADD CONSTRAINT `fk_rails_51749f8eac` FOREIGN KEY (`building_id`) REFERENCES `buildings` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
