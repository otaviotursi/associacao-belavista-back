CREATE TABLE TB_STATUS_EVENTO(
                                 ID INT NOT NULL,
                                 STATUS VARCHAR(255) NOT NULL,
                                 PRIMARY KEY(ID));

CREATE TABLE TB_TIPOS_EVENTOS(
                                 ID INT NOT NULL,
                                 NOME VARCHAR(255) NOT NULL,
                                 STATUS INT NOT NULL,
                                 PRIMARY KEY(ID));

ALTER TABLE `TB_TIPOS_EVENTOS` ADD CONSTRAINT `FK_STATUS` FOREIGN KEY ( `STATUS` ) REFERENCES `TB_STATUS_EVENTO` ( `ID` ) ;

CREATE TABLE TB_HORARIO_EVENTOS(
                                   ID INT NOT NULL,
                                   ID_TIPO_EVENTO INT NOT NULL,
                                   INICIO TIME NOT NULL,
                                   FIM TIME NOT NULL,
                                   DIA_SEMANA VARCHAR(255) NOT NULL,
                                   PRIMARY KEY(ID)
);

ALTER TABLE `TB_HORARIO_EVENTOS` ADD CONSTRAINT `FK_TIPO_EVENTOS` FOREIGN KEY ( `ID_TIPO_EVENTO` ) REFERENCES `TB_TIPOS_EVENTOS` ( `ID` ) ;

CREATE TABLE TB_STATUS_PAGAMENTO(
                                    ID INT NOT NULL,
                                    STATUS VARCHAR(255) NOT NULL,
                                    PRIMARY KEY(ID));

CREATE TABLE TB_SOLICITANTE(
                               ID INT NOT NULL,
                               NOME VARCHAR(255) NOT NULL,
                               CPF VARCHAR(256) NOT NULL,
                               TELEFONE VARCHAR(257) NULL,
                               PRIMARY KEY(ID)
);

CREATE TABLE TB_EVENTO_PARTICULAR(
                                     ID INT NOT NULL,
                                     ID_SOLICITANTE INT NOT NULL,
                                     DESCRICAO VARCHAR(255) NOT NULL,
                                     INICIO DATETIME NOT NULL,
                                     FIM DATETIME NOT NULL,
                                     ID_PAGAMENTO INT NOT NULL,
                                     ID_STATUS_EVENTO INT NOT NULL,
                                     PRIMARY KEY(ID)
);

ALTER TABLE `TB_EVENTO_PARTICULAR` ADD CONSTRAINT `FK_SOLICITANTE` FOREIGN KEY ( `ID_SOLICITANTE` ) REFERENCES `TB_SOLICITANTE` ( `ID` ) ;

ALTER TABLE `TB_EVENTO_PARTICULAR` ADD CONSTRAINT `FK_STATUS_EVENTO` FOREIGN KEY ( `ID_STATUS_EVENTO` ) REFERENCES `TB_STATUS_EVENTO` ( `ID` ) ;

CREATE TABLE TB_BANCO_IDEIAS(
                                ID INT NOT NULL,
                                NOME VARCHAR(255) NULL,
                                EMAIL VARCHAR(256) NULL,
                                DESCRICAO LONGTEXT NOT NULL,
                                PRIMARY KEY(ID)
);

CREATE TABLE TB_FEEDBACK(
                            ID INT NOT NULL,
                            NOME VARCHAR(255) NULL,
                            EMAIL VARCHAR(256) NULL,
                            DESCRICAO LONGTEXT NOT NULL,
                            NOTA INT NOT NULL,
                            DATA DATETIME NOT NULL,
                            PRIMARY KEY(ID)
);

CREATE TABLE TB_TIPO_USUARIO(
                                ID INT NOT NULL,
                                TIPO VARCHAR(255),
                                PRIMARY KEY(ID)
);

CREATE TABLE TB_USUARIO(
                           ID INT NOT NULL,
                           LOGIN VARCHAR(255) NOT NULL,
                           SENHA VARCHAR(256) NOT NULL,
                           NOME VARCHAR(257) NOT NULL,
                           ID_TIPO_USUARIO INT NULL,
                           PRIMARY KEY(ID)
);

ALTER TABLE `TB_USUARIO` ADD CONSTRAINT `FK_TIPO_USUARIO` FOREIGN KEY ( `ID_TIPO_USUARIO` ) REFERENCES `TB_TIPO_USUARIO` ( `ID` ) ;
