   M S B A M L   `   `   `  ���� D  @Roulette2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Roulette2	Roulette2      Roulette2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Roulette2       � Title$  Play the Game of Roulette��.��� ���	#FF207817$��0,0,-276,-372.333q�$
��Left=�$	��797�� � RowDefinitions �� $	��212 ��� .+��� -    ��Name$ redOne��$
��Left=�$��
184,88,0,0q�$��1��$	��Top=� �� TextAlignment$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41���� -   $ redThree��$
��Left=�$��
310,88,0,0q�$��3��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41���� -   $ redFive��$
��Left=�$��247,130,0,0q�$��5��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41���� -   $ redSeven��$
��Left=�$��184,172,0,0q�$��7��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��2���� -   $ redNine��$
��Left=�$��310,172,0,0q�$��9��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��2���� -   $ 	redTwelve��$
��Left=�$��	310,2,0,0q�$��12��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ 
redForteen��$
��Left=�$��
247,45,0,0q�$��14��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ 
redSixteen��$
��Left=�$��
184,87,0,0q�$��16��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -	   $ redNineteen��$
��Left=�$��184,129,0,0q�$��19��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -
   $ redTwentyOne��$
��Left=�$��310,129,0,0q�$��21��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ redTwentyThree��$
��Left=�$��247,172,0,0q�$��23��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ redTwentyFive��$
��Left=�$��184,214,0,0q�$��25��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ redTwentySeven��$
��Left=�$��310,214,0,0q�$��27��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ 	redThirty��$
��Left=�$��310,255,0,0q�$��30��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ redThirtyTwo��$
��Left=�$��247,297,0,0q�$��32��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ redThirtyFour��$
��Left=�$��184,339,0,0q�$��34��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ redEighteen��$
��Left=�$��
310,87,0,0q�$��18��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ redThirtySix��$
��Left=�$��310,339,0,0q�$��36��$	��Top=�$ Center=�$��24(�$
��Bold"�
���  ��$��62��$��41��$��1���� -   $ blackTwo��$
��Left=�$��
247,88,0,0q�$��2��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41���� -   $ 	blackFour��$
��Left=�$��184,130,0,0q�$��4��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41���� -   $ blackSix��$
��Left=�$��310,130,0,0q�$��6��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41���� -   $ 
blackEight��$
��Left=�$��247,172,0,0q�$��8��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��2���� -   $ blackTen��$
��Left=�$��	184,2,0,0q�$��10��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackEleven��$
��Left=�$��	247,2,0,0q�$��11��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackThirteen��$
��Left=�$��
184,45,0,0q�$��13��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackFifteen��$
��Left=�$��
310,45,0,0q�$��15��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackSeventeen��$
��Left=�$��
247,87,0,0q�$��17��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackTwenty��$
��Left=�$��247,129,0,0q�$��20��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackTwentyTwo��$
��Left=�$��184,172,0,0q�$��22��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackTwentyFour��$
��Left=�$��310,172,0,0q�$��24��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -   $ blackTwentySix��$
��Left=�$��247,214,0,0q�$��26��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -    $ blackTwentyEight��$
��Left=�$��184,255,0,0q�$��28��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -!   $ blackTwentyNine��$
��Left=�$��247,255,0,0q�$��29��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -"   $ blackThirtyOne��$
��Left=�$��184,297,0,0q�$��31��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -#   $ blackThirtyThree��$
��Left=�$��310,297,0,0q�$��33��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -$   $ blackThirtyFive��$
��Left=�$��247,339,0,0q�$��35��$	��Top=�$ Center=�$��24(�$
��Bold"�
���   �
�������$��62��$��41��$��1���� -%   $ TwoToOne2ndCol��$
��Left=�$��247,383,0,0q�$��2 to 1��$	��Top=�$ Center=�$��18(�$
��Bold"����	#FF207000
���   �$��62��$��1��$��24���� -&   $ TwoToOne1stCol��$
��Left=�$��184,383,0,0q�$��2 to 1��$	��Top=�$ Center=�$��18(�$
��Bold"����	#FF207000
���   �$��62��$��1��$��24���� -'   $ TwoToOne3rdCol��$
��Left=�$��310,383,0,0q�$��2 to 1��$	��Top=�$ Center=�$��18(�$
��Bold"����	#FF207000
���   �$��62��$��1��$��24���� -(   $ first12��$
��Left=�$��74.342,146.936,0,0q�$��1st 12��$	��Top=�$ Center=�$
��Bold"� J� RenderTransformOrigin$ 0.5,0.5&� � UseLayoutRounding .  $	��166��$��49��$��24(����	#FF207000z�V� .~��� �� ��  �� Angle$ 90Q�T� �� -)   $ second12��$
��Left=�$��75.5,103.833,0,0q�$��2nd 12��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $	��166��$��49��$��24(����	#FF207000$��1��z�V� .~��� �� �� $ 90Q�T� �� -*   $ third12��$
��Left=�$��76.5,271.833,0,0q�$��3rd 12��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $	��164��$��49��$��24(����	#FF207000$��1��z�V� .~��� �� �� $ 90Q�T� �� -+   $ evenSlot��$
��Left=�$��63.666,185.271,0,0q�$
��EVEN��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $��86��$��50.834��$��24(����	#FF207000$��2��z�V� .~��� �� �� $ 90Q�T� �� -,   $ oneTo18Slot��$
��Left=�$��67.416,102.25,0,0q�$��1 to 18��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $��78.166��$��50.668��$��20(����	#FF207000z�V� .~��� �� �� $ 90Q�T� �� --   $ redSlot��$
��Left=�$��65.166,60.688,0,0q�$	��RED��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $
��83.5��$��50.166��$��24(�
���  ��
���   �$��1��z�V� .~��� �� �� $ 90Q�T� �� -.   $ 	blackSlot��$
��Left=�$��64.666,145.355,0,0q�$��BLACK��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $��83.334��$��50.666��$��20(�
���   �
�������$��1��z�V� .~��� �� �� $ 90Q�T� �� -/   $ oddSlot��$
��Left=�$��63.666,231.417,0,0q�$	��ODD��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $��86��$��51.832��$��20(����	#FF207000$��1��z�V� .~��� �� �� $ 90Q�T� �� -0   $ nineteenTo36��$
��Left=�$��69.166,314.75,0,0q�$��19 to 36��$	��Top=�$ Center=�$
��Bold"�$ 0.5,0.5&� .  $��76��$��51.166��$��16(����	#FF207000$��1��z�V� .~��� �� �� $ 90Q�T� �� -1   $ zeroZero��$
��Left=�$��
277,55,0,0q�$��00��$	��Top=�$��95�����	#660F3806$
��Bold"�$ Center=�$��22(�$��29���� -2   $ 
singleZero��$
��Left=�$��
184,55,0,0q�$��0��$	��Top=�$��93�����	#660F3806$
��Bold"�$ Center=�$��22(�$��29���� -3   $
 Bets��$
��Left=�$��423,283,0,0q�$
��Wrap=�$�� ��$	��Top=�$	��126��$	��341��$��24(�$
��Bold"�$��1���� -4   $ 	BetsTitle��$
��Left=�$��
421,32,0,0q�$
��Wrap=�$��Bets:��$	��Top=�$��37��$��67��$��24(�$
��Bold"�$��1���� -5   $ Winning��$
��Left=�$��423,240,0,0q�$
��Wrap=�$��
Win Total:��$	��Top=�$��37��$	��139��$��24(�$
��Bold"�$��1���� -6   $ 	BetsTotal��$
��Left=�$��
421,75,0,0q�$
��Wrap=�$�� ��$	��Top=�$	��160��$	��185��$��24(�$
��Bold"�$ 1.214,0.532&�$��1���� -7    ��Name$ 	calculate��$��Go��$
��Left=�$��421,186,0,0q�$	��Top=�$��75��$��41��$��20(�$
��Bold"�$��2���� -8   $	 box��$
��Left=�$��
442,74,0,0q�$
��Wrap=�$�� ��$	��Top=�$��64��$��78���� $
��Left=�$	��186��$��
537,41,0,0q�$	��Top=�$	��176��$ 0.519,0.261&�$D��>C:\Users\Kandis\source\repos\Roulette2\Roulette2\ROULETTE1.gif��$��2���� -9    ��Name$ spinner��$
��Left=�$	��686��$��10,10,-45,0q�$	��Top=�$	��832��$D��>C:\Users\Kandis\source\repos\Roulette2\Roulette2\ROULETTE2.gif��$y�Hidden=�$��2��