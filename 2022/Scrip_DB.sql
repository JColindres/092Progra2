-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Proyecto_201602713
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Proyecto_201602713
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Proyecto_201602713` DEFAULT CHARACTER SET utf8mb4 ;
USE `Proyecto_201602713` ;

-- -----------------------------------------------------
-- Table `Proyecto_201602713`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Proyecto_201602713`.`Usuario` (
  `idUsuario` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `tipo_usuario` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_201602713`.`Artista`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Proyecto_201602713`.`Artista` (
  `idArtista` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `nacionalidad` VARCHAR(45) NOT NULL,
  `año_inicio` DATE NOT NULL,
  `img_cover` VARCHAR(200) NULL,
  PRIMARY KEY (`idArtista`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_201602713`.`Cancion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Proyecto_201602713`.`Cancion` (
  `idCancion` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(45) NOT NULL,
  `album` VARCHAR(45) NOT NULL,
  `fecha_lanzamiento` DATE NOT NULL,
  `genero` VARCHAR(45) NOT NULL,
  `ubicacion` VARCHAR(200) NOT NULL,
  `Artista_idArtista` INT NOT NULL,
  PRIMARY KEY (`idCancion`),
  INDEX `fk_Cancion_Artista_idx` (`Artista_idArtista` ASC) VISIBLE,
  CONSTRAINT `fk_Cancion_Artista`
    FOREIGN KEY (`Artista_idArtista`)
    REFERENCES `Proyecto_201602713`.`Artista` (`idArtista`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_201602713`.`Playlist`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Proyecto_201602713`.`Playlist` (
  `idPlaylist` INT NOT NULL AUTO_INCREMENT,
  `nombre_playlist` VARCHAR(45) NOT NULL,
  `fecha_creacion` DATE NOT NULL,
  `img_cover` VARCHAR(200) NULL,
  `Usuario_idUsuario` INT NOT NULL,
  PRIMARY KEY (`idPlaylist`),
  INDEX `fk_Playlist_Usuario1_idx` (`Usuario_idUsuario` ASC) VISIBLE,
  CONSTRAINT `fk_Playlist_Usuario1`
    FOREIGN KEY (`Usuario_idUsuario`)
    REFERENCES `Proyecto_201602713`.`Usuario` (`idUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_201602713`.`Playlist_has_Cancion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Proyecto_201602713`.`Playlist_has_Cancion` (
  `Playlist_idPlaylist` INT NOT NULL,
  `Cancion_idCancion` INT NOT NULL,
  PRIMARY KEY (`Playlist_idPlaylist`, `Cancion_idCancion`),
  INDEX `fk_Playlist_has_Cancion_Cancion1_idx` (`Cancion_idCancion` ASC) VISIBLE,
  INDEX `fk_Playlist_has_Cancion_Playlist1_idx` (`Playlist_idPlaylist` ASC) VISIBLE,
  CONSTRAINT `fk_Playlist_has_Cancion_Playlist1`
    FOREIGN KEY (`Playlist_idPlaylist`)
    REFERENCES `Proyecto_201602713`.`Playlist` (`idPlaylist`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Playlist_has_Cancion_Cancion1`
    FOREIGN KEY (`Cancion_idCancion`)
    REFERENCES `Proyecto_201602713`.`Cancion` (`idCancion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
