﻿using System.Xml.Linq;
using System;

import time
import random



def cdoh ():
    print("вы умерли..")
    exit()
def sa():
    print("Вы прошли достаточно далеко и увидели просто огромнейший стол с едой... вы впервые видите настолько прекрасные блюда")
    time.sleep(1)
    print("Выберите что будете делать: 1 Сьесть что нибудь. 2 Просто сесть за стол и ждать хозяев, может они подскажут что делать")
    sa2 = str(input("Введите ответ: "))
    if sa2 == "1":
        print("Вы начали есть... выели настолько быстро, что еда даже не успевала попадать вам в рот, как уже оказывалась в вашем желудке")
        time.sleep(1)
        cdoh()
    else:
        print("Вскоре вы видите хозяина стола... это шляпник, тот мило улыбается, но что то вас в нём пугает.")
        time.sleep(1)
        print("И когда тот приближается вы замечаете у него в руках нож.")
        time.sleep(1)
        print("Выберите что сделаете: 1. Убежать. 2. попробовать договориться")
        t = int(input())
        if t == 1:
            print("Вы убежали!")
        if t == 2:
            cdoh()
def ga():
    print("Вы встречаете безумца, тот сразу сказал вам, что без того чтобы вы решили загадку, он вас не пропустит.")
    time.sleep(1)
    print("Первая загадка: В синем небе светляки —Не дотянешь к ним руки.А один большой светляк. Изогнулся, как червяк.")
    zag1 = str(input("Введите ответ: "))
    if zag1 == "Звёзды и месяц":
        print("Вы убежали!")
    else:
        print("\"Не угадал! Давай ещё раз!\"")
        time.sleep(1)
        print("Речка спятила с ума —По домам пошла сама.")
        print("Введите ответ")
        wq = str(input("Введите ответ: "))
        if wq == "Водопровод":
            print("Вы убежали!")
        else:
            cdoh()
def fa():
    print("Вы находите палку... вы будете её подбирать?")
    time.sleep(1)
    print("1. Да 2. нет")
    time.sleep(1)
    x = int(input())
    if x == 1:
        print("Палка оказалась живая и проткнула вас")
        cdoh()
    else:
        print("Вы смогли не умереть)")
def game():
    print("Вы просыпаетесь в лесу... вы не знаете что происходит, начиная бежть куда то")
    x = random.randint(1, 3)
    if x == 1:
        sa()
    if x == 2:
        ga()
    if x == 3:
        fa()
print("Введите имя")
name = input()
game()
print("Вы идете или даже бежите дальше...")
time.sleep(1)
print("И вскоре вы видите просто огромный дом, однако вы будто думаете, что он родной для вас")
time.sleep(1)
print("Вы поддаётесь чувству, идя к нему")
time.sleep(1)
print("И вскоре спокойно заходите в него, смотря что внутри")
time.sleep(1)
print("Куда вы пойдёте?")
time.sleep(1)
print("1. На кухню, я хочу есть. 2. В гостинную, может здесь есть что то дорогое что смогу продать. 3. В спальню, я устал, надо бы поспать.")
time.sleep(1)
o = int(input())
if o == 1:
    print("Вы входите на кухню... еда, столь прекрасная... вы быстро берёте её...")
    time.sleep(1)
    print("И сьев столько, сколько вы смогли... вы быстро запихиваете в рюкзак булки где то пять штук, да после вы уходите в спальню.")
    time.sleep(1)
    inventar = str("Пять булок!")
if o == 2:
    print("Вы приходите в гостинную, тут и правда есть достаточно большое богатство...")
    time.sleep(1)
    print("Прямо на одной из тумбочек стоит огромная, золотая ваза, вы быстро берёте её, да уходите в спальню.")
    time.sleep(1)
    inventar = str("Огромная, золотая ваза!")
if o == 3:
    print("Вы спокойно идете в спальню, однако ничего там не находите")
    time.sleep(1)
wa = ["хорошая концовка", "Плохая концовка"]
print("Вы ложитесь на кровать... ваше тело ломит, а глаза закрываются почти сразу")
time.sleep(1)
print("И тут вы просыпаетесь... почему то вы чувствуете что вам очень страшно... ")
time.sleep(1)
print("Вас буквально трясёт...")
time.sleep(1)
print("Будто стены смотрят на вас, а в окнах вы будто видите лица...")
time.sleep(1)
print("А вот в дверь начали быстро скребстись... кажется кто то или что то знает, что вы тут")
time.sleep(1)
print("Что вы сделаете? 1. Спрятаться под кровать. 2. выпрыгнуть в окно. 3 наблюдать что будет дальше ")
time.sleep(1)
c = int(input())
if c == 1:
    print("Вы прячетесь под кровать.")
    time.sleep(1)
    print("Вы слышите как стучит ваше сердце, чуть ли не вырываясь из груди.")
    time.sleep(1)
    print("Ваше дыхание вас выдаёт, вы чувствуете это..")
    time.sleep(1)
    print("Но почему опасность будто сзади вас?")
    time.sleep(1)
    print("Вы не успеваете понять, что произошло... вас утаскивают во тьму")
    time.sleep(1)
    print(wa[1])
    cdoh()
if c == 2:
    print("Вы выпрыгиваете в окно...")
    time.sleep(1)
    print("Среди вас ночной лес и тысячи глаз смотрят будто вам в душу...")
    time.sleep(1)
    print("Не успевая что то понять, вы чувствуете, что ваш бок пронзила ужасная боль")
    time.sleep(1)
    print("Смотря вниз вы видите что вас проткнуло что то... это нож")
    time.sleep(1)
    print(wa[1])
    cdoh()
if c == 3:
    print("Вы видите как дверь медленно открывается...")
    time.sleep(1)
    print("Оттуда показывается... друид?")
    time.sleep(1)
    print("Тот смотрит на вас, пытаясь понять что вы тут делаете..")
    time.sleep(1)
    print("\" Что ты тут делаешь?! О боги... не отвечай, нам срочно надо уходить, иди за мной!... Только скажи, как тебя зовут?\"")
    time.sleep(1)
    print("Введите имя вновь:")
    time.sleep(1)
    name2 = input()
    time.sleep(1)
    print("Идя за незнакомцем, вы постоянно оглядываетесь, пытаясь понять что происходит...")
    time.sleep(1)
    print("Дом крайне сильно поменялся, везде какая то кровь, так же есть и множество разного рода конечностей...")
    time.sleep(1)
    print("Будто там была бойня и при том очень жестокая")
    time.sleep(1)
    print("Вы идете в подвал... Друид говорит, что вам нужен дакел, дабы видеть куда вам идти")
    time.sleep(1)
    print("Что вы сделаете? 1. Отломать от люка подвала достаточно большую деревяшку. после чего поджигаете её. 2. Снять одежду и поджечь её. 3. Попросить друида самому что то найти")
    time.sleep(1)
    t = int(input())
    print("Вы идете в освещённом тунеле... медленно, но верно вы приближаетесь к своей цели.")
    time.sleep(1)
    print("Вы уже видите выход...")
    time.sleep(1)
    print("Однако слышите, что сзади начинают скрестись в дверь погреба.")
    time.sleep(1)
    print("Ваш шаг увеличивается... надо бежать быстрее")
    time.sleep(1)
    if t == 1:
        print("Вы вспоминаете что отломали деревяшку от люка...")
        time.sleep(1)
        print("И ровно в этот момент двер открывается...")
        time.sleep(1)
        print("Вы и Друид не успели убежать...")
        time.sleep(1)
        cdoh()
    if t == 2:
        print("Однако дверь держиться хорошо...")
        time.sleep(1)
        print("Вы вместе с друидом смогли убежать")
        time.sleep(1)
        print(wa[0])
    if t == 3:
        print("Вы пытаетесь бежать...")
        time.sleep(1)
        print("Однако вас догоняют...")
        time.sleep(1)
        print("Понимание что тварь боиться света пришло слишком поздно...")
        time.sleep(1)
        print("Вы видитеогромное создание...")
        time.sleep(1)
        print("Его клыки кажется были остры как бритва")
        time.sleep(1)
        print("А глаза прожигали только вас")
        time.sleep(1)
        print("При том тело этой твари будто гнило изнутри")
        time.sleep(1)
        print("но вам было не до этого")
        time.sleep(1)
        print("Друид не решился спасать вас, убегая отсюда подальше..")
        time.sleep(1)
        print("Вас разодрали в клочья.")
        time.sleep(1)
        cdoh()


