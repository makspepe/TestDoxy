using System;
using System.Collections.Generic;
//using System.Threading.Tasks;

namespace TestDoxy
{
    /*!
     \brief Класс реализовывает стек

     \author makspepe
     \version 0.0.1
     \date 05.05.2021
     \warning Данный класс создан исключительно в учебных целях
     
    Класс реализовывает стек с заданным в скобках типом и методы связанные с ним 

    Пример:
    \code
    var stack = new TestStack<char>(); //char
    var stack1 = new TestStack<int>(); //int
    \endcode
 */
    class TestStack<T>
    {

        private List<T> arr = null;
        private int count = 0;

        /*!
         \brief Конструктор класса
        */
        public TestStack()
        {
            arr = new List<T>();
        }

        /*!
           \brief Размер стека


            \return Количество элементов в стеке (int)

           Пример: 
          \code
            var stack1 = new TestStack<int>();
            int x = stack1.Count; // Count == 0
            stack1.Add(999); // Добавили один элемент = 999
            x = stack1.Count; // Count == 1
          \endcode
         */
        public int Count => count;

        /*!
           \brief Добавление элемента в стек с заданным типом
 
            \param[in] val значение добавляемого элемента

        Добавляет элемент заданного типа (char/int/..) в стек со значением заданным val

        Пример:
         \code
         var stack = new TestStack<int>();
         stack.Add(10); // Добавили один элемент = 10
         \endcode
         */
        public void Add(T val)
        {
            arr.Add(val);
            count++;
        }

        /*!
         \brief Возвращает последний элемент стека

         \return Последний элемент стека

         Пример:
         \code
         var stack = new TestStack<int>();
         stack.Add(4); // Добавили элемент = 4
         Console.Write($"stack val = {stack.Push().ToString()}");  // stack val = 4
         \endcode
         */
        public T Push()
        {
            return arr[arr.Count - 1];
        }

        /*!
          \brief Удаляет последний эелемент стека

        Пример:
         \code
         var stack = new TestStack<int>();
         stack.Add(100); // Добавили элемент = 100
         stack.Add(9); // Добавили элемент = 9
         Console.Write($"stack val = {stack.Push().ToString()}"); //stack val = 9
         stack.Pop(); // Удаляем последний добавленный элемент (9)
         Console.Write($"stack val = {stack.Push().ToString()}"); //stack val = 100
         \endcode
         */
        public void Pop()
        {
            arr.Remove(arr[arr.Count - 1]);
            count--;
        }

        /*!
         \brief Существуют ли элементы в массиве

         Пример:
         \code
         var stack = new TestStack<int>();
         stack.IsExsist(); //false
         stack.Add(1);
         stack.IsExsist(); //true
         \endcode
         */
        public bool IsExsist()
        {
            return count > 0;
        }
    }
}
