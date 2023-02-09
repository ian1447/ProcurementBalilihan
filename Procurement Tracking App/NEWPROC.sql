/*
SQLyog Ultimate v9.62 
MySQL - 5.6.37-log : Database - procurement_tracking
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `purchase` */

CREATE TABLE `purchase` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `po_no` varchar(255) DEFAULT NULL,
  `description` text,
  `end_user` varchar(255) DEFAULT NULL,
  `mode_of_pr` varchar(255) DEFAULT NULL,
  `abc` int(11) DEFAULT NULL,
  `posting` datetime DEFAULT NULL,
  `opening_of_bids` datetime DEFAULT NULL,
  `preproc` datetime DEFAULT NULL,
  `prebid` datetime DEFAULT NULL,
  `detailed_bid_evaluation` datetime DEFAULT NULL,
  `award` datetime DEFAULT NULL,
  `po` datetime DEFAULT NULL,
  `ntp` datetime DEFAULT NULL,
  `delivery` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

/*Data for the table `purchase` */

insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (4,'123','343','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (5,'123','343','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (6,'1232','43','IRENE G. MAGLAHOS','PUBLIC BIDDING',23,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (7,'234','23','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT (SVP)',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (8,'23232','123','DR. EVANGIELYN P. LUMANTAS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (9,'123','123','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (10,'sd','23','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
insert  into `purchase`(`id`,`po_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`posting`,`opening_of_bids`,`preproc`,`prebid`,`detailed_bid_evaluation`,`award`,`po`,`ntp`,`delivery`) values (11,'asd','qwe','IRENE G. MAGLAHOS','NEGOTIATED PROCUREMENT (SVP)',123,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Table structure for table `purchase_breakdown` */

CREATE TABLE `purchase_breakdown` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `property_no` varchar(255) DEFAULT NULL,
  `unit` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `unit_cost` double DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `total_cost` int(11) DEFAULT NULL,
  `supplier` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `purchase_breakdown` */

/*Table structure for table `suppliers` */

CREATE TABLE `suppliers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `address` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `suppliers` */

insert  into `suppliers`(`id`,`name`,`address`) values (1,'try','try lang gd');
insert  into `suppliers`(`id`,`name`,`address`) values (2,'try2','trial 2');
insert  into `suppliers`(`id`,`name`,`address`) values (3,'Alturas Mall','Tagbilaran');
insert  into `suppliers`(`id`,`name`,`address`) values (4,'ICM','Dao Tagbilaran City');

/*Table structure for table `users` */

CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `privilege` enum('Admin','User') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`id`,`name`,`username`,`password`,`privilege`) values (1,'admin','admin','*4ACFE3202A5FF5CF467898FC58AAB1D615029441','Admin');

/* Procedure structure for procedure `sp_purchase_add` */

DELIMITER $$

/*!50003 CREATE DEFINER=`dev`@`%` PROCEDURE `sp_purchase_add`(
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

/* Procedure structure for procedure `sp_purchase_get` */

DELIMITER $$

/*!50003 CREATE DEFINER=`dev`@`%` PROCEDURE `sp_purchase_get`()
BEGIN
	select * from `purchase`;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_purchase_get_pr` */

DELIMITER $$

/*!50003 CREATE DEFINER=`dev`@`%` PROCEDURE `sp_purchase_get_pr`(
	in _po_no varchar (255)
    )
BEGIN
	select * from purchase where po_no = _po_no;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_add` */

DELIMITER $$

/*!50003 CREATE DEFINER=`dev`@`%` PROCEDURE `sp_supplier_add`(
	in _name varchar (255),
	in _address varchar (255)
    )
BEGIN
	insert into suppliers (`name`, address)
	values (_name,_address); 
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_delete` */

DELIMITER $$

/*!50003 CREATE DEFINER=`dev`@`%` PROCEDURE `sp_supplier_delete`(
	in _id int (11)
    )
BEGIN
	delete from `suppliers` where id = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_edit` */

DELIMITER $$

/*!50003 CREATE DEFINER=`dev`@`%` PROCEDURE `sp_supplier_edit`(
	in _name varchar (255),
	in _address varchar (255),
	in _id int (11)
    )
BEGIN
	update `suppliers` set `name` = _name, address = _address where id = _id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_get` */

DELIMITER $$

/*!50003 CREATE DEFINER=`dev`@`%` PROCEDURE `sp_supplier_get`()
BEGIN
	select * from suppliers;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
