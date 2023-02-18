/*
SQLyog Ultimate v9.62 
MySQL - 5.6.37-log : Database - procurement_tracking
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`procurement_tracking` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `procurement_tracking`;

/*Table structure for table `purchase` */

DROP TABLE IF EXISTS `purchase`;

CREATE TABLE `purchase` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `po_no` varchar(255) DEFAULT NULL,
  `description` text,
  `end_user` varchar(255) DEFAULT NULL,
  `mode_of_pr` varchar(255) DEFAULT NULL,
  `abc` int(11) DEFAULT NULL,
  `opening_of_bids` date DEFAULT NULL,
  `preproc` datetime DEFAULT NULL,
  `posting` datetime DEFAULT NULL,
  `prebid` datetime DEFAULT NULL,
  `detailed_bid_evaluation` datetime DEFAULT NULL,
  `award` datetime DEFAULT NULL,
  `po` datetime DEFAULT NULL,
  `ntp` datetime DEFAULT NULL,
  `delivery` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

/*Data for the table `purchase` */

insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`opening_of_bids`,`preproc`,`posting`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (4,'123','343adgfdfbxcvbsdgetywterysdfgh','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,'2023-02-01','2023-02-02 00:00:00','2023-02-03 00:00:00','2023-02-04 00:00:00','2023-02-04 00:00:00','2023-02-04 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-28 00:00:00'),(5,'123','343adgfdfbxcvbsdgetywterysdfgh','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,'2023-02-01','2023-02-02 00:00:00','2023-02-03 00:00:00','2023-02-04 00:00:00','2023-02-04 00:00:00','2023-02-04 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-28 00:00:00'),(6,'1232','43','IRENE G. MAGLAHOS','PUBLIC BIDDING',23,'2023-02-15',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,'234','23','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT (SVP)',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,'23232','123wala lang ahkds jahsdh f','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,'2023-02-15',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,'123','343adgfdfbxcvbsdgetywterysdfgh','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,'2023-02-01','2023-02-02 00:00:00','2023-02-03 00:00:00','2023-02-04 00:00:00','2023-02-04 00:00:00','2023-02-04 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-28 00:00:00'),(10,'sd','23','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,'2023-02-15',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,'asd','qwe','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT (SVP)',123,'2023-03-22',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,'32','32','DR. JOCELYN P. LUMACTUD','NEGOTIATED PROCUREMENT (SVP)',12,'2023-02-15',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(13,'78','786','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',78,'2023-02-15',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,'45','345','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',345,'2023-02-15',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,'23','123123','DR. DHOREE MAY R. MARAVILLA','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(16,'123343','231','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT (SVP)',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(17,'23234234','243','DR. JOCELYN P. LUMACTUD','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(18,'123123123','123','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(19,'342','123','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',1234345,NULL,NULL,'2023-02-15 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL),(20,'31','123','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT (SVP)',123,'2023-02-15','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00','2023-02-15 00:00:00'),(21,'123qwe','123','MARC BENIGNO C. OLAGUIR','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(22,'asdzxc','asd','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',212,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Table structure for table `purchase_breakdown` */

DROP TABLE IF EXISTS `purchase_breakdown`;

CREATE TABLE `purchase_breakdown` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `po_no` varchar(255) DEFAULT NULL,
  `property_no` varchar(255) DEFAULT NULL,
  `unit` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `unit_cost` double DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `total_cost` int(11) DEFAULT NULL,
  `supplier` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

/*Data for the table `purchase_breakdown` */

insert  into `purchase_breakdown`(`id`,`po_no`,`property_no`,`unit`,`description`,`unit_cost`,`quantity`,`total_cost`,`supplier`) values (1,NULL,'34','Mouse','wala',123,123,15129,'Alturas Mall'),(2,'23234234','123','3123','123',2,123,246,'Alturas Mall'),(3,'123123123','23123','123','sdf',435,23,10005,'try2'),(4,'123123123','454','345','345345345345erfgsdfgsdfg',345,345,119025,'try'),(5,'342','453','132','342',211,234,49374,'Alturas Mall'),(6,'31','3422','234','234',234,234,54756,'try2'),(7,'31','213','123','wdf',123,123,15129,'try'),(8,'asdzxc','1234qwe','asdasd','asdasd',123,12,1476,'try'),(10,'31','sghr','ertsefg','wertsdfgwer',3452345,234,807848730,'Alturas Mall');

/*Table structure for table `suppliers` */

DROP TABLE IF EXISTS `suppliers`;

CREATE TABLE `suppliers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `address` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `suppliers` */

insert  into `suppliers`(`id`,`name`,`address`) values (1,'try','try lang gd'),(2,'kitt','dasdasdas'),(3,'Alturas Mall','Tagbilaran'),(4,'ICM','Dao Tagbilaran City');

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `privilege` enum('Admin','User') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`id`,`name`,`username`,`password`,`privilege`) values (1,'admin','admin','*4ACFE3202A5FF5CF467898FC58AAB1D615029441','Admin'),(2,'kitt','kitt','123','User');

/* Procedure structure for procedure `sp_purchase_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purchase_add`(
	in _po_no varchar(255),
	in _description text,
	in _end_user varchar (255),
	in _mode_of_pr varchar (255),
	in _abc int(11)
    )
BEGIN
	insert into `purchase` (po_no,description,end_user,mode_of_pr,abc)
	values (_po_no,_description,_end_user,_mode_of_pr,_abc);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_breakdown_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_breakdown_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purchase_breakdown_add`(
	in _po_no varchar (255),
	in _property_no varchar (255),
	in _unit varchar (255),
	in _description varchar (255),
	in _unit_cost double,
	in _quantity int (11),
	in _total_cost int (11),
	in _supplier varchar (255)
    )
BEGIN
	insert into `purchase_breakdown` (po_no,property_no,unit,description,unit_cost,quantity,total_cost,supplier)
	value (_po_no,_property_no,_unit,_description,_unit_cost,_quantity,_total_cost,_supplier);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_breakdown_delete` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_breakdown_delete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purchase_breakdown_delete`(
	in _id int (11)
    )
BEGIN
	delete from `purchase_breakdown` where id = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_breakdown_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_breakdown_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purchase_breakdown_get`(
	in _po_no varchar(255)
    )
BEGIN
	select * from `purchase_breakdown` where po_no = _po_no;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purchase_edit`(
	IN _po_no VARCHAR (255),
	IN _description VARCHAR (255),
	IN _end_user VARCHAR (255),
	IN _mode_of_pr VARCHAR (255),
	IN _abc INT (11))
BEGIN
	update `purchase` set description = _description, end_user = _end_user, mode_of_pr = _mode_of_pr,abc = _abc 
	where po_no = _po_no;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purchase_get`()
BEGIN
	select * from `purchase`;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_get_pr` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_get_pr` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_purchase_get_pr`(
	in _po_no varchar (255)
    )
BEGIN
	select * from purchase where po_no = _po_no;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_update` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_purchase_update` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_purchase_update`(
	in _date datetime,
	IN _po_no VARCHAR (255),
	in _status varchar (255)
	)
BEGIN
	if _status = "Opening of Bids" THEN
		update `purchase` set opening_of_bids = DATE(_date) WHERE po_no = _po_no;
	end if;
	IF _status = "Pre-Proc" THEN
		UPDATE `purchase` SET preproc = DATE(_date) WHERE po_no = _po_no;
	END IF;	
	IF _status = "Posting" THEN
		UPDATE `purchase` SET posting = DATE(_date) WHERE po_no = _po_no;
	END IF;
	IF _status = "Pre-Bid" THEN
		UPDATE `purchase` SET prebid = DATE(_date) WHERE po_no = _po_no;
	END IF;
	IF _status = "Detailed Bid Evaluation" THEN
		UPDATE `purchase` SET detailed_bid_evaluation = DATE(_date) WHERE po_no = _po_no;
	END IF;
	IF _status = "Award" THEN
		UPDATE `purchase` SET award = DATE(_date) WHERE po_no = _po_no;
	END IF;
	IF _status = "PO" THEN
		UPDATE `purchase` SET po = DATE(_date) WHERE po_no = _po_no;
	END IF;
	IF _status = "NTP" THEN
		UPDATE `purchase` SET ntp = DATE(_date) WHERE po_no = _po_no;
	END IF;
	IF _status = "Delivery" THEN
		UPDATE `purchase` SET delivery = DATE(_date) WHERE po_no = _po_no;
	END IF;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_supplier_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_supplier_add`(
	in _name varchar (255),
	in _address varchar (255)
    )
BEGIN
	insert into suppliers (`name`, address)
	values (_name,_address); 
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_delete` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_supplier_delete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_supplier_delete`(
	in _id int (11)
    )
BEGIN
	delete from `suppliers` where id = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_supplier_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_supplier_edit`(
	in _name varchar (255),
	in _address varchar (255),
	in _id int (11)
    )
BEGIN
	update `suppliers` set `name` = _name, address = _address where id = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_supplier_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_supplier_get`()
BEGIN
	select * from suppliers;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_users_add` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_users_add` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_users_add`(
	in _name text,
	in _username text,
	in _password text,
	in _privelege text
    )
BEGIN
		insert into `users` (`name`, `username`, `password`,`privilege`)
		values(_name, _username, PASSWORD(_password), _privelege);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_users_edit` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_users_edit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_users_edit`(
	in _id int(11),
	in _name text,
	in _username text,
	in _password text 
    )
BEGIN
	update `users` 
	set
		`name` = _name,
		`username` = _username,
		`password` = _password
	where 
		id = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_users_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_users_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`system_admin`@`%` PROCEDURE `sp_users_get`()
BEGIN
	select * from users;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
