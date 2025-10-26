drop sequence if exists SEQ_ARMAS cascade;
drop sequence if exists SEQ_MAPAS cascade;
drop table if exists TBL_ARMAS cascade;
drop table if exists TBL_MAPAS cascade;

create sequence SEQ_ARMAS
    minvalue 1
    maxvalue 999999
    increment by 1
    start with 1;

create sequence SEQ_MAPAS
    minvalue 1
    maxvalue 999999
    increment by 1
    start with 1;

create table TBL_ARMAS (
    ID_ARMA BIGINT not null default nextval('SEQ_ARMAS'),
    NOME_ARMA VARCHAR(20) not null,
    TIPO VARCHAR(20) not null,
    DANO INT not null,
    PRECISAO INT not null,               
    CADENCIA INT not null,               
    PRECO INT not null,
    DESCRICAO VARCHAR(150) not null,
    IMAGEM_ARMA VARCHAR(200) not null,
    constraint PK_ARMA primary key (ID_ARMA)
);

create table TBL_MAPAS (
    ID_MAPA BIGINT not null default nextval('SEQ_MAPAS'),
    NOME_MAPA VARCHAR(20) not null,
    LOCALIZACAO VARCHAR(20) not null,
    TAMANHO VARCHAR(10) not null,       
    LAYOUT VARCHAR(15) not null,         
    LADO_FAVORITO VARCHAR(15) not null,  
    DESCRICAO VARCHAR(150) not null,
    IMAGEM_MAPA VARCHAR(200) not null,
    constraint PK_MAPA primary key (ID_MAPA)
);

INSERT INTO TBL_ARMAS (NOME_ARMA, TIPO, DANO, PRECISAO, CADENCIA, PRECO, DESCRICAO, IMAGEM_ARMA) VALUES
('USP-S', 'Pistola', 35, 85, 300, 200, 'Pistola padrão dos CTs com silenciador removível.', '/assets/armas/usps.png'),
('Glock-18', 'Pistola', 28, 78, 400, 200, 'Pistola padrão dos terroristas, alta cadência e modo burst.', '/assets/armas/glock18.png'),
('Desert Eagle', 'Pistola', 63, 70, 160, 700, 'Pistola poderosa, alto dano mas baixa precisão.', '/assets/armas/deagle.png'),
('CZ75-Auto', 'Pistola', 31, 76, 450, 500, 'Pistola automática com pouca munição.', '/assets/armas/cz75.png'),
('Tec-9', 'Pistola', 33, 74, 420, 500, 'Alta cadência e dano em curta distância.', '/assets/armas/tec9.png'),
('Five-SeveN', 'Pistola', 32, 82, 420, 500, 'Alta penetração e precisão.', '/assets/armas/fiveseven.png'),
('P90', 'SMG', 26, 78, 900, 2350, 'Alta cadência e grande pente.', '/assets/armas/p90.png'),
('MP9', 'SMG', 28, 80, 900, 1250, 'SMG leve dos CTs, rápida e barata.', '/assets/armas/mp9.png'),
('MAC-10', 'SMG', 27, 75, 1050, 1050, 'SMG barata dos terroristas.', '/assets/armas/mac10.png'),
('Negev', 'Metralhadora', 35, 70, 1000, 1700, 'Alta cadência e supressão.', '/assets/armas/negev.png'),
('M249', 'Metralhadora', 32, 72, 750, 5200, 'Pesada com grande volume de fogo.', '/assets/armas/m249.png'),
('Nova', 'Shotgun', 120, 60, 68, 1050, 'Espingarda barata, ótima em curta distância.', '/assets/armas/nova.png'),
('XM1014', 'Shotgun', 120, 65, 171, 2000, 'Espingarda automática de alto DPS.', '/assets/armas/xm1014.png'),
('AK-47', 'Rifle', 36, 78, 600, 2700, 'Alta penetração e dano.', '/assets/armas/ak47.png'),
('M4A4', 'Rifle', 33, 82, 600, 3100, 'Boa precisão e controle de recuo.', '/assets/armas/m4a4.png'),
('M4A1-S', 'Rifle', 33, 84, 600, 2900, 'Rifle CT com silenciador, boa precisão e recuo controlado.', '/assets/armas/m4a1s.png'),
('FAMAS', 'Rifle', 30, 78, 600, 2050, 'Econômico e equilibrado.', '/assets/armas/famas.png'),
('Galil AR', 'Rifle', 30, 76, 600, 1800, 'Bom custo-benefício.', '/assets/armas/galil.png'),
('SG 553', 'Rifle', 30, 86, 545, 3000, 'Rifle com mira óptica dos TRs.', '/assets/armas/sg553.png'),
('AUG', 'Rifle', 28, 86, 545, 3300, 'Rifle com mira óptica dos CTs.', '/assets/armas/aug.png'),
('AWP', 'Sniper', 115, 95, 41, 4750, 'Rifle de precisão com alto dano.', '/assets/armas/awp.png');

INSERT INTO TBL_MAPAS (NOME_MAPA, LOCALIZACAO, TAMANHO, LAYOUT, LADO_FAVORITO, DESCRICAO, IMAGEM_MAPA) VALUES
('Dust II', 'Deserto', 'Médio', 'Aberto', 'TR', 'Mapa clássico com longas rotas e bombsites abertos.', '/assets/mapas/dust2.png'),
('Mirage', 'Marrocos', 'Médio', 'Misto', 'Balanceado', 'Controle de meio e equilíbrio entre bombsites.', '/assets/mapas/mirage.png'),
('Inferno', 'Itália', 'Médio', 'Fechado', 'CT', 'Confrontos intensos em corredores estreitos.', '/assets/mapas/inferno.png'),
('Nuke', 'EUA', 'Grande', 'Fechado', 'CT', 'Complexo industrial com múltiplos níveis.', '/assets/mapas/nuke.png'),
('Overpass', 'Alemanha', 'Grande', 'Misto', 'CT', 'Mapa urbano com túneis e passagens elevadas.', '/assets/mapas/overpass.png'),
('Ancient', 'América do Sul', 'Médio', 'Fechado', 'CT', 'Ruínas antigas com zonas intensas de combate.', '/assets/mapas/ancient.png'),
('Vertigo', 'Nova York', 'Médio', 'Aberto', 'TR', 'Prédio em construção com combates em altura.', '/assets/mapas/vertigo.png'),
('Anubis', 'Egito', 'Grande', 'Misto', 'TR', 'Corredores sinuosos e arquitetura egípcia.', '/assets/mapas/anubis.png');
