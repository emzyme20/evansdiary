import type { Media } from "../types";

export interface TimelineEntry {
  year: number;
  heading: string;
  description: string;
  link?: {
    href: string;
    label: string;
  };
  images?: Media[];
  video?: Media;
  type: "Event" | "Video" | "Blog" | "Image";
}

export const athleticsTimeline: readonly TimelineEntry[] = [
  {
    year: 2008,
    type: "Event",
    heading: "Nursery Mini Olympics",
    description:
      "Evan's nursery 'Brightstart Nursery' held a mini olympics event where all the children were introduced to sporting events. Evan had already demonstrated with any activity that we would do together how competitive he was and how much he hated to lose.",
    images: [
      {
        source: "2008_sprint_race_dzze6k",
        caption: "Sprint Race",
        width: 285,
        height: 214,
      },
      {
        source: "2008_medals_nl626v",
        caption: "Medal Ceremony",
        width: 285,
        height: 214,
      },
    ],
  },
  {
    year: 2010,
    type: "Blog",
    heading: "Showing interest in athletics",
    description: `Evan showed a keen interest in running from an early age. At any sporting event held from Nursery through to the Primary School ages he would put himself forward to run in the running race.

He is naturally a very competitive boy and we found that his Primary School in particular removed the whole competitive attitude from Sports Day and it became a 'Let's Take Part' affair.

I understand that not everyone is good at or enjoys sports but then I also know that not everyone is academic as well, but you never see a school saying to those children 'Oh well, let's just take part'. It's the one thing about modern schooling that I disagree with. You have Sport for England wondering why we aren't creating athletes capable of competing at an Elite level, it all starts at the grass roots, at the schools! 

Understandably, Evan was not really getting the exposure to athletics and encouragement at school, however, he was attending holiday clubs at a local Sports Centre affiliated to the Secondary School in our area. It was here that he was spotted by a Track and Field coach because he seemed to be very good at high jump when they did this activity. Evan did not make the connection when selecting activities to do at the club that athletics actually meant running. As soon as he had learned the meaning of that word, it was always the first activity chosen if it was available on the days that he attended.`,
  },
  {
    year: 2010,
    type: "Event",
    heading: "First Sports Day",
    description:
      "Evan's first sports day sees him qualify for the individual sprint race. The qualification events are held during school time in the weeks leading up to Sports Day.",
    images: [
      {
        source: "2010_sports_day_nh1cd7",
        caption: "Sprint Race",
        width: 350,
      },
    ],
  },
  {
    year: 2011,
    type: "Blog",
    heading: "Tribe Athletics",
    description: `We were given the details of an athletics club that runs at the University of Bath. This was pre 2012 Olympics, which has since inspired more young children to choose athletics so luckily the waiting list was not too long and we were able to get him in during 2011.
The Tribe athletics club was a fun way to introduce an array of track and field activities to young children.`,
    link: {
      href: "https://www.teambath.com/tribe-schools/",
      label: "Learn more about Team Bath Tribe",
    },
  },
  {
    year: 2013,
    type: "Blog",
    heading: "Team Bath 365 Athletics Club",
    description: `Evan was starting to outgrow Tribe and wanted to have a go at competing. Competing is particularly hard when you are not affiliated to an athletics club, you have to compete as an independent and research all the events and activities yourself.
We decided to put Evan on the waiting list to join Team Bath 365, at 8 years old he was still too young to join this club, which accepts children when they reach 9 as they would be competing in the youngest age category U11's.
In the summer before his 9th birthday, we decided to take Evan along to a few open athletics meets to compete as an Independent just to get a feel for what it's like. You can get similar issues in athletics to those that actors get when they get 'Stage Fright' performing and the earlier you tackle this the better.`,
    link: {
      href: "https://teambathac.org/home/365-academy/",
      label: "Learn more about Team Bath 365",
    },
  },
  {
    year: 2013,
    type: "Event",
    heading: "Year 3 Sports Day",
    description: `At 8 years old, Evan is proving to be a very confident sprinter. He loves all aspects of the 'Sports Day' event at school but it is only the running race at the end of the day that has any competitive element.
Evan always qualifies as the fastest runner in his class/ house group and as a result he only gets to race the sprint. He has shown interest in also running the relay event but the policy of his primary school is
that the same child cannot run both. The fastest runs the individual event and the next 4 fastest will run the relay.`,
    images: [
      {
        source: "2013_sports_day_xfblzc",
        caption: "Sprint Race",
        width: 350,
      },
    ],
  },
  {
    year: 2014,
    type: "Blog",
    heading: "Team Bath Futures",
    description: `When Evan made it into the 365 athletics club, which is just a step up from Tribe but with older children, we decided to investigate if there were any other sessions that Evan could do to fine tune his natural ability.
This is when we found out about the Talent Development Centre (TDC), which also operates out of the University of Bath.
You are initially invited to an assessment day where they put you through a series of tests and activities (parents were not invited to watch).
If successful, you can then choose from a variety of sessions that you can then attend that focus on improving specific attributes. E.g. Speed and Agility, Strength, Power etc..
TDC caters for a variety of Sports so Evan gets to work alongside people from a variery of sports e.g. Swimmers, Rugby players, Footballers and of varying ages.
When he started to sessions at 10 years of age, he was training alongside 14 and 15 year olds. Being amongst the older children focused Evan more because there is less emphasis on play.
TDC is now known as Team Bath Futures.`,
    link: {
      href: "https://www.teambath.com/tribe-schools/team-bath-futures/",
      label: "Learn more about Team Bath Futures",
    },
  },
  {
    year: 2014,
    type: "Event",
    heading: "Year 4 Sports Day",
    description: `Evan was back to his best this year. The 2013 year 3 sports day event was a wash out. We had booked the day off only to be alerted at the start of the day that due to the bad weather
the event would be postponed. It was a little premature from the school as by the afternoon, the weather was absolutely fine. This year with Evan now 9, he was keen to get back to winning ways as the
event the year before ended up being held indoors and Evan had a slip and recovered to finish only 2nd. You could tell that competing for Team Bath was having an effect on Evan. At the start of the race
this year he remained focused, performing the kind of pre-race routine that Elite runners like Usain Bolt would go through—Evan even asked if he could wear his spikes! The children lining up next to Evan were just chatting and joking waiting for the race to start.
Evan had an outstanding race, finishing a comfortable 1st.`,
    images: [
      {
        source: "2014_sports_day_track_yetvkd",
        caption: "Sprint Race",
        width: 285,
      },
      {
        source: "2014_sports_day_field_ea7glo",
        caption: "Egg and Spoon",
        width: 285,
      },
    ],
  },
  {
    year: 2014,
    type: "Event",
    heading: "Kidstri Triathlon",
    description: `Evan loves animals, from your everyday household pets to those that live in the wild. Evan was keen to challenge his abilities and wanted to try a triathlon.
He thought seeing as it was his first attempt, it would be a worthy fund raising opportunity. He decided to support an elephant charity called Tusk Trust.
He did exceptionally well and raised over £100 for them and he also raced very well considering he'd never competed over a long distance like this before.`,
    images: [
      {
        source: "2014_kidstri_ride_mff9qh",
        caption: "The Ride",
        width: 285,
      },
      {
        source: "2014_kidstri_run_qntigu",
        caption: "The Run",
        width: 285,
      },
      {
        source: "2014_kidstri_end_brjloo",
        caption: "Triathlon Completed!",
        width: 285,
      },
      {
        source: "2014_kidstri_medal_lbikulh",
        caption: "The Medal",
        width: 285,
      },
    ],
  },
  {
    year: 2015,
    type: "Video",
    heading: "Year 5 Sports Day",
    description: `Although there is no pressure to perform at sports day, Evan sometimes feels that he has to perform well because of his previous successes. He is a very competitive.`,
    images: [
      {
        source: "2015_sprint_skmj84",
        caption: "Sprint Race",
        width: 285,
      },
    ],
    video: {
      source: "http://www.youtube.com/embed/LUgBYkUAnn8",
      caption: "Sprint Race Video",
      width: 350,
    },
  },
  {
    year: 2016,
    type: "Event",
    heading: "Junior Aquathlon",
    description: `Evan thoroughly enjoyed his triathlon a few years ago but didn't enjoy the bike stage of it. We have since discovered that you can do various combinations of these kinds of events.
As a result, Evan being a very good runner and swimmer decided to have a go at an aquathlon which combines his preferred events. We found an event local to us run by the Trowbridge Hotchilli Triathlon Club, which caters for all age groups.
The day of the event was a horrible day (weather-wise), the transition stage was being held in the tennis courts, so athletes would have to run from the swimming pool along the concrete in bare feet before being able to change into trainers for the run.
It rained quite heavily leading up to the race, however by the time Evan emerged from his 800m swim, it was just overcast. The concrete was very slippy, which saw several people slip over!
Evan made it to the transition stage in one piece. The 1200m run was a real slog, it was cold and you tend to find that it's not so much of a race because of the long distance swim that gaps between the competitors build up and you are completing a time trial instead of a race.
The athletes all wear tags around their ankles so that you know when they started and finished and from those times you can calculate the race time.`,
    link: {
      href: "https://www.britishtriathlon.org/clubs/trowbridge-hot-chilli-triathlon-club_1869",
      label: "Contact Trowbridge Hot Chilli Triathlon Club",
    },
    images: [
      {
        source: "2016_aquathlon_ybxjei",
        caption: "Run Stage",
        width: 350,
      },
    ],
  },
  {
    year: 2016,
    type: "Video",
    heading: "Year 6 Sports Day",
    description: `Evan's last sports day of primary school, he wanted to go out with a bang. He ran well and the whole school acknowledged how good he is at running by chanting his name at the start of the race.
His house team 'Sharks' overall performed poorly against the other house teams but Evan was pleased with the running race that he won.`,
    images: [
      {
        source: "2016_sprint_vroti5",
        caption: "Sprint Race",
        width: 350,
      },
    ],
    video: {
      source: "http://www.youtube.com/embed/myLbwK4oh74",
      caption: "Sprint Race Video",
      width: 350,
    },
  },
  {
    year: 2016,
    type: "Image",
    heading: "Primary School Awards Ceremony",
    description: `Evan won the award of 'Sports Person of the Year' voted for by his peers. He has represented his primary school for many sporting activities over the years.
He is very pleased to have been rewarded with this award as he leaves the school to embark on a new chapter at secondary school.`,
    images: [
      {
        source: "2016_sports_person_ecidnk",
        caption: "Sports Person of the Year",
        width: 350,
      },
    ],
  },
  {
    year: 2016,
    type: "Event",
    heading: "Personal Best for the 100m",
    description: `On the 11th September 2016, Evan represented Team Bath at an athletics open meet. He ran the 100m and competed in the javelin.
He ran his personal best time of 14.5 seconds for the 100m finishing second in his race.`,
    images: [
      {
        source: "2016_100m_pb_jmnsij",
        caption: "100m montage",
        width: 500,
        quality: 100,
      },
      {
        source: "2016_100m_pb_y6rmei",
        caption: "100m PB",
        width: 350,
        quality: 100,
      },
    ],
  },
  {
    year: 2016,
    type: "Event",
    heading: "Beechen Cliff - The Great Walk 2016",
    description: `On the 12th October 2016, Evan took part in a school event to raise funds for his secondary school, it involved completing a course from the school grounds to a point in a neighboring town Bradgford Upon Avon. The course was a total of 21 miles and was split into phases to allow the whole school to take part. There were points along the course where different age groups would stop and turn around. The children started the walk at 8:20am and were set a deadline to turn around at mid-day to allow them to be back at the school by 3pm.
In the weeks leading up to this event, Evan had been completing a cross-country run for his weekly PE lesson. The week before the event arrived, he came home with a slip that we had to sign that would allow him to go past the designated year 7 point and to also run the course with a group of other boys who had been selected based on their performance in the cross-country lessons throughout the term. This challenge was very exciting for Evan and he is always looking for something new to do to test his stamina and performance. We purchased a Camelbak back pack that allows you to run with fluid in your bag that you can drink without having to use bottles as he was keen to complete the course with a good time.
Evan made a very good start on the day, with us tracking him using his mobile phone GPS, we established that he made it to Bradford Upon Avon and was already on his way back at 10am. His return journey was a lot harder. By mid-day his legs were starting to tire and he was suffering with aches and pains. This was the first time that Evan has ever run a distance like this and the resulting problems that effect your muscles when they are fatgiued. He continued at a much slower pace with the determination and desire that it is better to finish than not finish at all. He finished at roughly 1pm, an incredible achievement for an 11 year old running almost the distance of a marathon in a time that most adults would be proud of.`,
    link: {
      href: "https://uk.camelbak.com/hydration-packs/",
      label: "Learn more about Camelbak hydration packs",
    },
    images: [
      {
        source: "2016_great_walk_daxbgs",
        caption: "The Great Walk",
        width: 350,
      },
    ],
  },
];
