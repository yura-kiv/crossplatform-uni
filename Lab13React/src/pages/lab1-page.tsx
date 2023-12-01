import { CodeSnippet } from "src/components/code-snippet";
import LabForm from "src/components/lab-form";
import { PageLayout } from "src/components/page-layout";
import { useLabResult } from "src/hooks/useLabResult";

const Lab1Page: React.FC = () => {
  const { result, getResult } = useLabResult(1);

  return (
    <PageLayout>
      <div className="content-layout">
        <h1
          id="page-title"
          className="content__title"
        >
          Лабораторна робота 1
        </h1>
        <div className="content__body">
          <p id="page-description">
            <span>
              Марсіяни Мишко та Маша вирішили разом підібрати подарунок на день народження Каті.
              Коли вони нарешті знайшли те, що хотіли, та запакували предмет у гарну коробку, треба
              було вирішити, як підписати подарунок. Друзі подумали, що найкращим рішенням буде
              скласти загальний підпис так, щоб у ньому як підрядки містилися їхні імена. Майте на
              увазі, що на Марсі прийнято підписуватися повними іменами, а вони у марсіан можуть
              бути досить довгими.
            </span>
          </p>
          <h3 className="content__title">Приклад файлу введення:</h3>
          <p id="page-description">
            <span>
              Julya
              <br />
              Lyalya
            </span>
          </p>
          <h3 className="content__title">Приклад файлу виведення:</h3>
          <p id="page-description">
            <span>JuLyalya</span>
          </p>

          <LabForm submitHandler={getResult} />
          <CodeSnippet
            title="Результат:"
            code={result}
          />
        </div>
      </div>
    </PageLayout>
  );
};

export default Lab1Page;
