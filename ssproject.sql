/*
 Navicat Premium Data Transfer

 Source Server         : lokalna
 Source Server Type    : MySQL
 Source Server Version : 50639
 Source Host           : localhost:3306
 Source Schema         : ssproject

 Target Server Type    : MySQL
 Target Server Version : 50639
 File Encoding         : 65001

 Date: 08/06/2018 09:50:34
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for colors
-- ----------------------------
DROP TABLE IF EXISTS `colors`;
CREATE TABLE `colors`  (
  `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `hex_value` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_polish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for companies
-- ----------------------------
DROP TABLE IF EXISTS `companies`;
CREATE TABLE `companies`  (
  `id` int(255) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NULL DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_polish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `status` enum('just_ordered','in_progress','done') CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL DEFAULT 'just_ordered',
  `order_table` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `picture_id` int(255) UNSIGNED NULL DEFAULT NULL,
  `client_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `client_email` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NULL DEFAULT NULL,
  `client_phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NULL DEFAULT NULL,
  `end_date` datetime(0) NOT NULL,
  `order_date` datetime(0) NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `markup_percentage` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL DEFAULT '10' COMMENT 'marża %',
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `picture_id`(`picture_id`) USING BTREE,
  CONSTRAINT `picture_id` FOREIGN KEY (`picture_id`) REFERENCES `pictures` (`id`) ON DELETE SET NULL ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_polish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for pictures
-- ----------------------------
DROP TABLE IF EXISTS `pictures`;
CREATE TABLE `pictures`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `picture_data` longtext CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_polish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for singleitemorder
-- ----------------------------
DROP TABLE IF EXISTS `singleitemorder`;
CREATE TABLE `singleitemorder`  (
  `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `order_id` int(10) UNSIGNED NOT NULL,
  `tshirt_id` int(10) UNSIGNED NOT NULL,
  `amount` int(255) UNSIGNED NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `tshirt_id`(`tshirt_id`) USING BTREE,
  INDEX `order_id`(`order_id`) USING BTREE,
  CONSTRAINT `order_id` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `tshirt_id` FOREIGN KEY (`tshirt_id`) REFERENCES `tshirts` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_polish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for styles
-- ----------------------------
DROP TABLE IF EXISTS `styles`;
CREATE TABLE `styles`  (
  `id` int(255) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_polish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for tshirts
-- ----------------------------
DROP TABLE IF EXISTS `tshirts`;
CREATE TABLE `tshirts`  (
  `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `company_id` int(255) UNSIGNED NOT NULL,
  `style_id` int(255) UNSIGNED NOT NULL,
  `sex` enum('man','woman','unisex') CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL DEFAULT 'unisex',
  `color_id` int(255) UNSIGNED NOT NULL,
  `price` decimal(10, 2) NOT NULL,
  `available` int(255) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `company_id`(`company_id`) USING BTREE,
  INDEX `style_id`(`style_id`) USING BTREE,
  INDEX `color_id`(`color_id`) USING BTREE,
  CONSTRAINT `color_id` FOREIGN KEY (`color_id`) REFERENCES `colors` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `company_id` FOREIGN KEY (`company_id`) REFERENCES `companies` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `style_id` FOREIGN KEY (`style_id`) REFERENCES `styles` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_polish_ci ROW_FORMAT = Compact;

SET FOREIGN_KEY_CHECKS = 1;
