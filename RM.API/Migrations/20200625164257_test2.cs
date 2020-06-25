using Microsoft.EntityFrameworkCore.Migrations;

namespace RM.API.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Character", "Episode", "Quote" },
                values: new object[] { "Rick Sanchez", "Rick and Morty, Season 4: Rattlestar Ricklactica", "I wasn't born into the God business, I fucking earned it." });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Character", "Episode", "Quote" },
                values: new object[] { "Rick Sanchez", "Rick and Morty, Season 4: One Crew Over the Crewcoo's Morty", "I programmed you to believe that." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Character", "Episode", "Quote" },
                values: new object[,]
                {
                    { 71, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Auto Erotic Assimilation", "[they both exchange kisses, upping their sexual arousal]Unity: Yes, Rick, yes! Yes, yes!Rick: Wait, wait, stop! H-Hold it! Not like this. We need a hang glider, and a crotchless Uncle Sam costume, and I want the entire field of your largest stadium covered end to end with naked redheads, and I want the stands packed with every man that remotely resembles my father." },
                    { 70, "Morty Smith (voice)", "Rick and Morty, Season 1: Something Ricked This Way Comes", "Morty: And also, knock next time, you know? I mean, I'm sitting in here, I'm fourteen! I got a computer in here, you know?Jerry: Oh, I, uh... I think I understa—Morty: You know, you're really playing with fire when you burst in here like that, man.Jerry: I get it. Say no more.Morty: I mean one of these days, you know, you're gonna—you're gonna—you're gonna end up seeing something." },
                    { 69, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Something Ricked This Way Comes", "Rick: Have you acquired creepy specific old stuff from a mysterious antique or thrift store that gives you powers, but fucks with you in unforeseeable ways? Bring it to 'Curse Purge Plus'! I-I use science to un-curse the items for cash, and you get to keep the powers. This guy got mysterious sneakers to make him run faster, but guess what? He would've had to run until he died, making them worthless. I removed the curse, making them worth, like, I don't know, $8 million? See you at the Olympics. This eerily intelligent doll was threatening to murder its family. Now it does their taxes.Doll: Everything's deductible.Rick: Don't pay for cool stuff with your soul. Pay for it with money. You know, like how every store in the world works?" },
                    { 68, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Pilot", "And then we're gonna go on even more adventures after that, Morty. And you're gonna keep your mouth shut about it, Morty! Because the world is full of idiots that don't understand what's important, and they'll tear us apart, Morty! But if you stick with me, I'm gonna accomplish great things, Morty, and you're gonna be part of 'em. And together we're gonna run around, Morty, we're gonna- do all of kinds of wonderful things, Morty. Just you and me, Morty." },
                    { 67, "Summer Smith (voice)", "Rick and Morty, Season 1: Rixty Minutes", "You're the little brother. You're not the cause of your parents' misery, you're just a symptom of it." },
                    { 66, "Beth Smith (voice)", "Rick and Morty, Season 2: Total Rickall", "Beth: Sorry Jerry, you're real.Jerry: [crying] I'm a parasite!Beth: Yeah... but you're real." },
                    { 65, "Evil Morty Smith (voice)", "Rick and Morty, Season 3: The Ricklantis Mixup", "This seems like a good time for a drink, and a cold, calculated speech with sinister overtones. A speech about politics, about order, brotherhood, power... but speeches are for campaigning. Now is the time for action." },
                    { 64, "Morty Smith (voice)", "Rick and Morty, Season 3: Morty's Mind Blowers", "How many of these are just horrible mistakes I made? I mean, maybe I'd stop making so many if I let myself learn from them." },
                    { 63, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Anatomy Park", "Bloom: Anatomy Park's greatest attraction, young man, isn't the music or the food or the... Pirates of the Pancreas.Rick: 'Watch it!'" },
                    { 62, "Rick Sanchez (voice)", "Rick and Morty, Season 2: A Rickle in Time", "Beth: Sweetie, is your shirt on backwards?Jerry: ...Yeah! I like it this way. I'm not stupid!Rick: Man that guy is the Redgrin Grumbholt of pretending he knows what's going on." },
                    { 61, "Jerry Smith (voice)", "Rick and Morty, Season 1: Rick Potion #9", "Meh, try not to worry about it, Morty. You're a good kid. And there's not a premium on that right now, but you'll be getting girls sometime after Brad's out of shape." },
                    { 60, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The ABC's of Beth", "I don't know, maybe you matter so little that I like you. Or maybe it makes you matter. Maybe I love you. Maybe something about your mother. Don't jump a gift shark in the mouth." },
                    { 59, "Summer Smith (voice)", "Rick and Morty, Season 3: The Rickshank Redemption", "We're miserable Morty! There's a mandatory curfew, their weird calendar made me 47, and they've weaponized the Eiffel tower!" },
                    { 58, "Morty Smith (voice)", "Rick and Morty, Season 2: Look Who's Purging Now", "SCREW YOU, RICK! I'LL PURGE YOU TOO, YOU OLD... \"RICKETY\" PIECE OF CRAP! THIS HAS BEEN A LONG TIME COMING! I'M GONNA RIP YOUR FUCKING GUTS OUT AND SMEAR 'EM ALL OVER YOUR FACE! I AIN'T TAKING NO SH-AAAHH!!" },
                    { 57, "Rick Sanchez (voice)", "Rick and Morty, Season 2: The Ricks Must Be Crazy", "They named a holiday after me. Ricksgiving. They teach kids about me in school!" },
                    { 56, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Mortynight Run", "SHUT THE FUCK UP ABOUT MOONMEN! This isn't a musical number! This is a fucking... operation, we gotta be cool and fucking lay low." },
                    { 55, "Rick Sanchez (voice)", "Rick and Morty, Season 2: The Wedding Squanchers", "See? Our cup runneth over. Now, who wants to go shopping for a brand-new motherfuckin' world?! All right!" },
                    { 54, "Jerry Smith (voice)", "Rick and Morty, Season 1: Rixty Minutes", "All this time, you've been thinking, 'What if that loser Jerry hadn't talked me out of the abortion?' Well, now you know, you'd be a doctor. Whoop-dee-doo. You'd also be drinking wine, alone in a house full of exotic birds. And I'd be on DiCaprio's yacht, banging Kristen Stewart!" },
                    { 53, "Morty Smith (voice)", "Rick and Morty, Season 2: Get Schwifty", "Morty: Can you fly a Black Hawk?Mr. President: Can the pope's **** fit through a donut?Morty: Eh... I'm not sure?Mr. President: Exactly!" },
                    { 52, "Jerry Smith (voice)", "Rick and Morty, Season 2: Interdimensional Cable 2", "Yes, I will! That's right, assholes! Take my penis. Take it all!! And tell Shrimply Pibbles that when the galaxy came calling, Jerry Smith from Earth didn't flinch!" },
                    { 72, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "Lick, lick, lick my balls! Ha ha ha, yeah!" },
                    { 73, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Anatomy Park", "Listen, if the situation keeps on darkening, then you gotta do yourself a favor and pop by Pirates Of The Pancreas. I mean, the top priority is to, you know, get you guys out of there, but, I mean, if that becomes impossible then you gotta treat yourself." },
                    { 74, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The ABC's of Beth", "Put a saddle on your universe. Let it kick itself out." },
                    { 75, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The Ricklantis Mixup", "You got some of that mermaid puss." },
                    { 95, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Rick Potion #9", "Rick: Alright, Morty, I just gotta erhp combine it with some of your DNA.Morty: Oh well, okay. [unzips]Rick: A hair, Morty. I need one of your hairs. This isn't Game of Thrones." },
                    { 94, "Party-Goer", "Rick and Morty, Season 1: Ricksy Business", "And this is why you don't invite a Floopy Doop and a Shmoopy Doop to the same party." },
                    { 93, "Jerry Smith (voice)", "Rick and Morty, Season 1: M. Night Shaym-Aliens!", "Well, all is forgiven, because right now, I’ve got an erection the size of an East Coast lighthouse, and I’m coming home to share it with my beautiful wife." },
                    { 92, "Morty Smith (voice)", "Rick and Morty, Season 1: M. Night Shaym-Aliens!", "No, no, I haven't seen that. I mean, why would a Pop-Tart want to live inside a toaster, Rick? I mean, th-that would be like the scariest place for them to live. Y'know what I mean?" },
                    { 91, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "Get off the high road, Summer! We all got pinkeye because you won't stop texting on the toilet." },
                    { 90, "Morty Smith (voice)", "Rick and Morty, Season 1: Raising Gazorpazorp", "Morty: So what?! Y-Y-You could do things inside! Y-You could play guitar, you could masturbate!Morty Jr.: I don't wanna masturbate! I wanna conquer the planet!" },
                    { 89, "Summer Smith (voice)", "Rick and Morty, Season 2: Total Rickall", "All I have are pictures are of me and my friends from school. What? What teenage girl has pictures of her family? It's not like we're Mormon or dying" },
                    { 88, "Jerry Smith (voice)", "Rick and Morty, Season 1: Rixty Minutes", "Beth: When two people create a life together, they set aside their previous lives as individuals.Jerry: Gimme a break! We're not heroes for having unprotected sex on prom night." },
                    { 87, "Rick Sanchez (voice)", "Rick and Morty, Season 3: Rickmancing the Stone", "To live is to risk it all, otherwise you're just an inert chunk of randomly assembled molecules drifting wherever the universe blows you." },
                    { 51, "Rick Sanchez (voice)", "Rick and Morty, Season 3: Rest and Ricklaxation", "Yeah motherfucker yeah get it get some, right up your fucking bitch ass you fuck! Guess who just discovered a new element! Think you could do that Morty? You think anyonne but me could do it ever in a billion years? Do you think if God existed he could do it? The answer is no. If God exists its fucking me!" },
                    { 86, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The Rickchurian Mortydate", "I'm Doctor Who in this motherfucker! I could be a clone! I could be a hologram! We could clones controlled by robots controlled by special headsets that the real Rick and Morty are wearing while they're fucking your mother!" },
                    { 84, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Ricksy Business", "TO GET R*ugghhb*IGGITY RIGGITY WRECKED SOONN" },
                    { 83, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Mortynight Run", "Stupid-ass, fart-saving, carpet-store motherfucker." },
                    { 82, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Close Rick-Counters of the Rick Kind", "Don't break an arm jerking yourself off, Morty." },
                    { 81, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The ABC's of Beth", "Beth: Am I evil?Rick: Worse, you're smart. When you know nothing matters, the universe is yours. And I've never met a universe that was into it. The universe is basically an animal, it grazes on the ordinary. It creates infinite idiots, just to eat them, not unlike your friend Timmy." },
                    { 80, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The Rickshank Redemption", "Yeah, well, tough titties." },
                    { 79, "Rick Sanchez (voice)", "Rick and Morty, Season 3: Pickle Rick", "I'M A PICKLE! I'm pickle Riiiiiick!" },
                    { 78, "Rick Sanchez (voice)", "Rick and Morty, Season 2: A Rickle in Time", "Morty: If you could get out that whole time why didn't you?Rick: Because I waited until I was certain it was what I wanted to do, Morty! That's the difference between you and me: I'm certain, and you're a walking burlap sack filled with turds." },
                    { 77, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Big Trouble in Little Sanchez", "The universe is a little too big to care about something so small." },
                    { 76, "Jerry Smith (voice)", "Rick and Morty, Season 1: Anatomy Park", "Jerry: It sounds like you're about to say Jacob is your lover.Leonard Smith: No, no, no. Jacob is your mother's lover. I watch them. Sometimes from a chair, sometimes from a closet. Almost always dressed as Superman." },
                    { 85, "Jerry Smith (voice)", "Rick and Morty, Season 2: Interdimensional Cable 2", "Ambassador: Mr. Smith, Shrimply Pibbles' life can be saved... if we replace his heart with your human penis.Jerry: I see... Wait, what?!" },
                    { 50, "Morty Smith (voice)", "Rick and Morty, Season 1: Ricksy Business", "Bird Person: Morty, do you know what wubba lubba dub dub means?Morty: Oh, that's just Rick's stupid nonsense catchphrase.Bird Person: It's not nonsense at all. In my people's tongue, it means, I am in great pain. Please help me." },
                    { 49, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Lawnmower Dog", "Morty: You're talking about Inception?Rick: That's right, Morty! This is gonna be a lot like that, except y'know, it's gonna me-beh... make sense.Morty: Inception made sense!Rick: You don't have to try and impress me, Morty!" },
                    { 48, "Rick Sanchez (voice)", "Rick and Morty, Season 2: A Rickle in Time", "So, in conclusion, you're both equally mercurial, overly sensitive, clingy, hysterical bird-brain homunculi. And I honestly can't even tell the two of you apart half the time because I don't go by height or age, I go by amount of pain in my ass—which makes you both identical." },
                    { 22, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "Jerry: Rick, I don't like glowing rocks in the kitchen trash!Rick: Well, I don't like your unemployed genes in my grandchildren, Jerry, but life is made of little concessions." },
                    { 21, "Rick Sanchez (voice)", "Rick and Morty, Season 2: The Ricks Must Be Crazy", "Morty, you gotta flip 'em off. I told them it means 'peace among worlds.' How hilarious is that!" },
                    { 20, "Rick Sanchez (voice)", "Rick and Morty, Season 2: The Ricks Must Be Crazy", "Wait for the ramp, Morty. They love the slow ramp. It really gets their dicks hard" },
                    { 19, "Morty Smith (voice)", "Rick and Morty, Season 2: Get Schwifty", "Mr. President, if I've learned one thing today, it's that sometimes you have to not give a fuck!" },
                    { 18, "Unity", "Rick and Morty, Season 2: Auto Erotic Assimilation", "Morty: Uhm, should we maybe stop somewhere and get you a coffee? Maybe splash a little water on your face, or...?Unity: No, no. If I wanted to be sober, I wouldn't have gotten drunk." },
                    { 17, "Rick Sanchez / Morty Smith (voice)", "Rick and Morty, Season 2: Auto Erotic Assimilation", "Don't waste your brain on those weirdos, Unity. They're no different from any of the aimless chumps that you occupy. They just put you at the center of their lives because you're powerful. And then, because they put you there, they want you to be less powerful. Never gonna happen though, right?" },
                    { 16, "Summer Smith (voice)", "Rick and Morty, Season 2: Auto Erotic Assimilation", "[addressing Rick] You and Unity are like... like leggings and mid-calf boots. You think you're great together, but you're just bringing out the worst in each other." },
                    { 15, "Rick Sanchez / Morty Smith (voice)", "Rick and Morty, Season 2: Mortynight Run", "Morty: You sold a gun to a murderer so you could play video games?Rick: Yeah, sure, I mean, if you spend all day shuffling words around, you can make anything sound bad, Morty." },
                    { 14, "Summer Smith (voice)", "Rick and Morty, Season 2: Total Rickall", "Ooh yeah, shame me. At least when I'm disgusting it's on purpose." },
                    { 23, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Meeseeks and Destroy", "I can't wait to watch your adventure lay a huge fart." },
                    { 13, "Morty Smith", "Rick and Morty, Season 2: The Ricks Must Be Crazy", "You guys, are the fucking worst! Your gods are a lie! Fuck you, fuck nature and fuck trees!" },
                    { 11, "Rick Sanchez", "Rick and Morty, Season 4: Edge of Tomorty", "Morty, you know outer space is up right?" },
                    { 10, "Morty Smith", "Rick and Morty, Season 4: Edge of Tomorty", "I ain't better than shit, Jack" },
                    { 9, "Rick Sanchez", "Rick and Morty, Season 4: Edge of Tomorty", "There's a lesson here and I'm not going to be the one to figure it out." },
                    { 8, "Rick Sanchez", "Rick and Morty, Season 4: Edge of Tomorty", "I think you have to think ahead and live in the moment." },
                    { 7, "Morty Smith", "Rick and Morty, Season 4: Edge of Tomorty", "Must... continue... moving... in... ways... that... lead... to... dying... with... you." },
                    { 6, "Jerry Smith (voice)", "Rick and Morty, Season 4: The Old Man and the Seat", "You can't stay mad a guy with this amount of talent." },
                    { 5, "Summer Smith (voice)", "Rick and Morty, Season 4: The Old Man and the Seat", "I going to daughter your brains out, bitch." },
                    { 4, "Rick Sanchez", "Rick and Morty, Season 4: One Crew Over the Crewcoo's Morty", "Stealing stuff is about the stuff, not the stealing." },
                    { 3, "Morty Smith", "Rick and Morty, Season 4: One Crew Over the Crewcoo's Morty", "Whose kidneys are these?" },
                    { 12, "Rick Sanchez (voice)", "Rick and Morty, Season 3: Vindicators 3", "" },
                    { 24, "Morty Smith (voice)", "Rick and Morty, Season 2: The Ricks Must Be Crazy", "I masturbated to an extra curvy piece of driftwood the other day!" },
                    { 25, "Mr. Meeseeks", "Rick and Morty, Season 1: Meeseeks and Destroy", "I'm Mr. Meeseeks! Look at me!" },
                    { 26, "Morty Jr.", "Rick and Morty, Season 1: Raising Gazorpazorp", "My life has been a lie! God is dead! The government's lame! Thanksgiving is about killing Indians! Jesus wasn't born on Christmas! They moved the date, it was a pagan holiday!" },
                    { 47, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Get Schwifty", "Get Schwifty." },
                    { 46, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Ricksy Business", "It's not the same, Summer! Lincler's a crazed maniac. He's just a misguided effort of mine to create a morally neutral super-leader by combining the DNA of Adolf Hitler and Abraham Lincoln. Turns out that ehh-it just adds up to a lame, weird... loser." },
                    { 45, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Big Trouble in Little Sanchez", "Huntin' a vampire with my grandkids!! FUCK!! TINY RI-I-ICK!!!" },
                    { 44, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "And that's why I always say, 'shum-shum-schlippety-dop!'" },
                    { 43, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "Wubba-lubba-dub-dub!" },
                    { 42, "Pichael Thompson", "Rick and Morty, Season 2: Interdimensional Cable 2", "Pichael Thompson: And then they found out I was attached along for the ride and they said, 'Ah, shit. Well, just fuck it, call him Pichael.'Michael Thompson: [throws papers at Pichael's face] Fuck you, Pichael! You're a fucking piece of shit!" },
                    { 41, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Mortynight Run", "Right, yeah, like nothing shady ever happened in a fully furnished office? You ever hear about Wall Street, Morty? Y-Y-Y'know what those guys do i-in-in their fancy boardrooms? They take their balls and they dip 'em in cocaine and wipe 'em all over each other—y'know, Grandpa goes around and he does his business in public, because Grandpa isn't shady." },
                    { 40, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "Rubber baby bubby bunkers!" },
                    { 39, "Poncho", "Rick and Morty, Season 1: Anatomy Park", "That's right, baby. A lot of people would pay top dollar to decimate the population. I'll take the highest bidder—Al-Qaeda, North Korea, Republicans, shriners, balding men that work out, people on the Internet that are only turned on by cartoons of Japanese teenagers. Anything is better than working for you, you pompous, negligent, iTunes-gift-card-as-a-holiday bonus-giving mother—" },
                    { 38, "Morty Smith (voice)", "Rick and Morty, Season 2: Big Trouble in Little Sanchez", "Well then get your shit together, get it all together and put it in a back pack, all your shit, so it's together. And if you gotta take it some where, take it somewhere, you know, take it to the shit store and sell it, or put it in the shit museum. I don't care what you do, you just gotta get it together.Get your shit together." },
                    { 37, "Rick Sanchez (voice)", "Rick and Morty, Season 2: A Rickle in Time", "Morty, sit here. Summer, you sit here. Now, listen—I know the two of you are very different from each other in a lot of ways, but you have to understand that as far as Grandpa's concerned, you're both pieces of shit! Yeah. I can prove it mathematically. Actually, l-l-let me grab my whiteboard. This has been a long time coming, anyways." },
                    { 36, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "Mr. Beauregard: Ah, Master Rick, remember when you weren't going to shoot me?Rick: [shoots Mr. Beauregard in the face] I guess Iiii did the butler! Hahaaa! Does that, does that scan?Ghost in a Jar: Oh, I-I get it. It's a play on 'the butler did it.'Rick: Thanks Ghost in a Jar. You always were good at pointing out potentially obscure comedy." },
                    { 35, "Rick Sanchez (voice)", "Rick and Morty, Season 1: Pilot", "We're the only fehh-friends we got, Morty! It's just Rick and Morty! Ruh-ick and Morty and their adventures, Morty! Rick and Morty forever and forever, 100 years, Rick and Morty's things! Me and Rick and Morty running around and... Rick and Morty time! All day long, forever... all- a hundred days! Rick and Morty forever a hundred times!" },
                    { 34, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The Whirly Dirly Conspiracy", "'I took your family'? Who do you think had taken more from them when you shot 20 CCs of liquid dreamkiller into my daughter? She was Rick's daughter, Jerry! She had options! That all ended because she felt sorry for you. You act like prey, but you're a predator! You use pity to lure in your victims! That's how you survive! I survive cause I know everything, that snake survives because children wander off, and you survive 'cause people think 'Ooh, this poor piece of shit, he never gets a break! I can't stand the deafening silent wails of his wilting soul! I guess I'll hire him or marry him!'" },
                    { 33, "Rick Sanchez (voice)", "Rick and Morty, Season 2: Total Rickall", "Rick: No, \"Steve\" put that memory in your brain so he could live in your house, eat your food and multiply. We could be infested with these things. So, we got to keep an eye out for any zany, wacky characters that pop up.Mr. Poopybutthole: Oooohwee! Whatever you want, Rick, we're here to help!Rick: Thanks, Mr. Poopybutthole. I always could count on you." },
                    { 32, "Rick Sanchez (voice)", "Rick and Morty, Season 2: The Ricks Must Be Crazy", "Morty: You have a whole planet... sitting around making your power for you?! That's slavery!Rick: It's society! They work for each other, Morty. They pay each other, they buy houses, they get married and make children that replace them when they get too old to make power.Morty: That just sounds like slavery with extra steps!Rick: Ooh-la-la, someone's gonna get laid in college." },
                    { 31, "Rick Sanchez (voice)", "Rick and Morty, Season 3: Pickle Rick", "Because I don't respect therapy. Because I'm a scientist. Because I invent, transform, create, and destroy for a living, and when I don't like something about the world, I change it. And I don't think going to a rented office in a strip mall to listen to some agent of averageness explain which words mean which feelings has ever helped anyone do anything. I think it's helped a lot of people get comfortable and stop panicking, which is a state of mind we value in the animals we eat, but not something I want for myself. I'm not a cow. I'm a pickle. When I feel like it. So... you asked." },
                    { 30, "Rick Sanchez (voice)", "Rick and Morty, Season 3: The Rickshank Redemption", "An-and I-I-I'll go out and I'll find some more of that Mulan Szechuan teriyaki dipping sauce, Morty! Th-b-because that's what this is all about, Morty! Th-that's my one-armed man! I'm not driven by avenging my dead family, Morty, that was fake! I-I-I'm driven by finding that McNugget sauce! I want that Mulan McNugget sauce, Morty! That's my series arc, Morty! If it takes nine seasons, I want my McNugget... dipping sauce Szechuan sauce, Morty! That's what's gon-it's gonna take us all the way to the end, Morty!" },
                    { 29, "Summer Smith (voice)", "Rick and Morty, Season 2: Look Who's Purging Now", "Jerry: What' you doing? Watching some tv, playing on your phone?Summer: Is that a real question?Jerry: Just making conversation.Summer: Are you? What part of that gives me anything to work with? My choice is to: say nothing, be sarcastic, or bark \"yes\" like a trained animal. It's not a conversation; you're holding me verbally hostage." },
                    { 28, "Morty Smith (voice)", "Rick and Morty, Season 3: The Rickchurian Mortydate", "President: Here's the adventure: some kind of alien goo-ga has infested the Kennedy Sex Tunnels. I want it hunted down and taken out.Morty: Kennedy Sex Tunnels?President: Naturally you'll forget you saw them, along with, in order of national embarrassment: the Truman Cocaine Lounge, the McKinley Hooker Dump, and the Lincoln Slave Colosseum. He didn't free them all. And let me know when you're done" },
                    { 27, "Jerry Smith (voice)", "Rick and Morty, Season 2: Interdimensional Cable 2", "Shrimply Pibbles: I've dwelt among the humans. Their entire culture is built around their penises. It's funny to say they are small. It's funny to say they are big. I've been at parties where humans held bottles, pencils, thermoses in front of themselves and called out, 'Hey, look at me. I'm Mr. So-and-So Dick. I've got such-as-such for a penis.' I never saw it fail to get a laugh.Jerry: All right! That's enough! You guys are talking about my species! We understand genocide! We do it sometimes!" },
                    { 96, "Rick Sanchez", "Rick and Morty, Season 1: Raising Gazorpazorp", "60 for the resonator, and my grandson wants the sex robot." },
                    { 97, "Summer Smith (voice)", "Rick and Morty, Season 2: The Ricks Must Be Crazy", "Summer: You know you're kind of a dick, right?Rick's Computer: My function is to 'keep Summer safe', not 'keep Summer being, like, totally stoked about, like, the general vibe, and stuff'. That's you, that's how you talk." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Character", "Episode", "Quote" },
                values: new object[] { "David", "derp", "Derp 1" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Character", "Episode", "Quote" },
                values: new object[] { "Davida", "derp2", "Derp 2" });
        }
    }
}
